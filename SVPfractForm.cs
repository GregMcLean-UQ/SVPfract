using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace SVPfract
{
    public partial class SPVfractForm : Form
    {
        HourlyData hourlyData;
        List<DailyRecord> dailyData;

        List<int> includedMonths;
        public SPVfractForm()
        {
            InitializeComponent();
        }
        private void SPVfractForm_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 12; i++)
            {
                fromMonth.Items.Add(CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(i));
                toMonth.Items.Add(CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(i));
            }
            fromMonth.SelectedIndex = 0;
            toMonth.SelectedIndex = 11;
        }

        private void MetFileLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Get the met file data
            MetFileNameLabel.Text = @"C:\Pioneer\SPVfract\WoodlandHourly2019.csv";
            if (openFileDialog.ShowDialog() != DialogResult.OK) return;
            MetFileNameLabel.Text = openFileDialog.FileName;
            ReadMetData();
        }
        private void ReadMetData()
        {
            // load data into structures 
            // may need latitude to decide sunup and sundown
            hourlyData = new HourlyData(0.0);
            var lines = File.ReadAllLines(MetFileNameLabel.Text);
            foreach (string line in lines.Skip(1))
            {
                hourlyData.hourlyRecords.Add(new HourlyRecord(line));
            }



        }

        private void CalcLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Calculate average VPD in sunshine hours and svpMaxT, svpMint
            dailyData = new List<DailyRecord>();

            double radnThreshold = Convert.ToDouble(minRadnTextBox.Text);

            // For each day get values and record in a dailyData
            DateTime firstDay = hourlyData.hourlyRecords.First().dateTime.Date;
            DateTime lastDay = hourlyData.hourlyRecords.Last().dateTime.Date;



            for (DateTime dt = firstDay; dt <= lastDay; dt = dt.AddDays(1))
            {
                try
                {
                    var dayData = from x in hourlyData.hourlyRecords where (x.dateTime.Date == dt && includedMonths.Contains(x.dateTime.Month)) select x;
                    var avgVPD = (from y in dayData where y.radiation > radnThreshold select y.vpd).Average();
                    var minT = (from y in dayData select y.temperature).Min();
                    var svpMaxT = dayData.OrderBy(p => p.temperature).Last().svp;
                    var svpMinT = dayData.OrderBy(p => p.temperature).First().svp;

                    dailyData.Add(new DailyRecord(dt, avgVPD, svpMaxT, svpMinT));
                }
                catch (Exception ex)
                {

                }
            }
            // try different values for svpFract to minimise sum of squares of the differenecs

            double minSvpFract = 0; ;
            double minSSD = 50000.0;
            for (double svpFract = 0.5; svpFract < 0.9; svpFract += 0.05)
            {
                // calculate ssd
                double sumSSD = 0;
                foreach (DailyRecord rec in dailyData)
                {
                    sumSSD += Math.Pow(((rec.svpMaxT - rec.svpMinT) * svpFract - rec.avgVPD), 2.0);
                }
                if (sumSSD < minSSD)
                {
                    minSSD = sumSSD;
                    minSvpFract = svpFract;
                }
            }

            spvFractLabel.Text = minSvpFract.ToString("F3");
            foreach (DailyRecord rec in dailyData)
            {
                rec.CalcPredVPD(minSvpFract);
            }

            // graph data 
            DrawGraph(minSvpFract.ToString("F3"));


        }
        public void DrawGraph(string svpFract)
        {
            // Graph the predicted vs obs VPD
            string title = Path.GetFileNameWithoutExtension(MetFileNameLabel.Text) + " From " + fromMonth.Text + " To " + toMonth.Text;
            chart.Titles[0].Text = title; ;
            chart.Titles[1].Text = "SVP Fraction = " + svpFract;
            chart.Series[0].Points.Clear();
            foreach (DailyRecord rec in dailyData)
            {
                chart.Series[0].Points.AddXY(rec.avgVPD, rec.predVPD);
            }

            var obsVPD = from x in dailyData select x.avgVPD;
            var predVPD = from x in dailyData select x.predVPD;
            Stats s = new Stats();

            double slope, intercept, rsq, rmse;
            s.calcRegression(obsVPD.ToArray(), predVPD.ToArray(), out slope, out intercept, out rsq, out rmse);
            chart.Series[1].Points.Clear();
            chart.Series[1].Points.AddXY(0, 0);
            double maxVal = obsVPD.Max();
            chart.Series[1].Points.AddXY(maxVal, maxVal * slope + intercept);
            TextAnnotation ta = new TextAnnotation();
            ta.Text = "";
            ((TextAnnotation)(chart.Annotations[0])).Text = "y = " + slope.ToString("F2") + "x + " +
                intercept.ToString("F2") + "\n rsq = " + rsq.ToString("F2") + " rmse = " + rmse.ToString("F2") + " n = " + obsVPD.Count();
        }
        #region Menu Items
        private void copyItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
            ContextMenuStrip menuStrip = (ContextMenuStrip)menuItem.GetCurrentParent();
            Chart cht = (Chart)(menuStrip.SourceControl);


            // create a memory stream to save the chart image    
            System.IO.MemoryStream stream = new System.IO.MemoryStream();
            // save the chart image to the stream    
            cht.SaveImage(stream, System.Drawing.Imaging.ImageFormat.Bmp);

            // create a bitmap using the stream    
            Bitmap bmp = new Bitmap(stream);

            // save the bitmap to the clipboard    
            Clipboard.SetDataObject(bmp);
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
            ContextMenuStrip menuStrip = (ContextMenuStrip)menuItem.GetCurrentParent();
            Chart cht = (Chart)(menuStrip.SourceControl);

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            // Sets the current file name filter string, which determines 
            // the choices that appear in the "Save as file type" or 
            // "Files of type" box in the dialog box.
            saveFileDialog1.Filter = "Bitmap (*.bmp)|*.bmp|JPEG (*.jpg)|*.jpg|EMF (*.emf)|*.emf|PNG (*.png)|*.png|GIF (*.gif)|*.gif|TIFF (*.tif)|*.tif";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            // Set image file format
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ChartImageFormat format = ChartImageFormat.Bmp;

                if (saveFileDialog1.FileName.EndsWith("bmp")) format = ChartImageFormat.Bmp;
                else if (saveFileDialog1.FileName.EndsWith("jpg")) format = ChartImageFormat.Jpeg;
                else if (saveFileDialog1.FileName.EndsWith("emf")) format = ChartImageFormat.Emf;
                else if (saveFileDialog1.FileName.EndsWith("gif")) format = ChartImageFormat.Gif;
                else if (saveFileDialog1.FileName.EndsWith("png")) format = ChartImageFormat.Png;
                else if (saveFileDialog1.FileName.EndsWith("tif")) format = ChartImageFormat.Tiff;

                // Save image
                cht.SaveImage(saveFileDialog1.FileName, format);

            }
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------
        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
            ContextMenuStrip menuStrip = (ContextMenuStrip)menuItem.GetCurrentParent();
            Chart cht = (Chart)(menuStrip.SourceControl);
            cht.Printing.PrintPreview();
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
            ContextMenuStrip menuStrip = (ContextMenuStrip)menuItem.GetCurrentParent();
            Chart cht = (Chart)(menuStrip.SourceControl);
            cht.Printing.Print(true);

        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------------------------------------------------------
        private void exportDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveDataFile.ShowDialog() != System.Windows.Forms.DialogResult.OK) return;
            string csvFileName = saveDataFile.FileName;

            List<string> lines = new List<string>();
            foreach (DataPoint pt in chart.Series["Data"].Points)
            {
                string line = pt.XValue.ToString("F4") + "," + pt.YValues[0].ToString("F4");
                lines.Add(line);
            }
            File.WriteAllLines(csvFileName, lines);

        }
        #endregion

        private void ReChartLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // For every day in the month selected plot temperature
            int selectedMonth = fromMonth.SelectedIndex + 1;
            var dayData = from x in hourlyData.hourlyRecords where (x.dateTime.Month == selectedMonth) select x;

            temperatureChart.Series.Clear();
            List<double> dailyMax = new List<double>();
            List<double> dailyMin = new List<double>();

            for (int doy = dayData.First().doy; doy <= dayData.Last().doy; doy++)
            {
                var hourData = from x in hourlyData.hourlyRecords where (x.doy == doy) select x;

                // For each day draw a line of temperature vs hour of day
                String seriesName = "Year" + hourData.First().dateTime.Year.ToString() + "Day" + doy.ToString();
                Series newDay = temperatureChart.Series.Add(seriesName);
                newDay.ChartType = SeriesChartType.Line;
                newDay.Color = Color.Wheat;
                newDay.ToolTip = seriesName;
                foreach (HourlyRecord hd in hourData)
                {
                    newDay.Points.AddXY(hd.dateTime.Hour - 1, hd.temperature);
                }
                dailyMax.Add((from x in hourData select x.temperature).Max());
                dailyMin.Add((from x in hourData select x.temperature).Min());
            }


            // Add estimated temperatures for a day in the middle of the month with average monthly tMax and tMin
            double latitude = Convert.ToDouble(latTextBox.Text);
            double midMonth = dayData.First().doy + 15;

            double tMax = dailyMax.Average();
            double tMin = dailyMin.Average();
            double minLag = Convert.ToDouble(minLagTextBox.Text);
            double maxLag = Convert.ToDouble(maxLagTextBox.Text);
            double nightCoef = Convert.ToDouble(nightCoefTextBox.Text);

            var estHourly = calcTemperature(latitude, midMonth, tMax, tMin, minLag, maxLag, nightCoef);

            Series pred = temperatureChart.Series.Add("Predicted");
            pred.ChartType = SeriesChartType.Line;
            pred.Color = Color.Black;
            pred.ToolTip = "Predicted";
            for (int i = 0; i < estHourly.Count; i++)
            {
                pred.Points.AddXY(i, estHourly[i]);
            }

        }


        private void IncludedMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetIncludedMonths();
        }
        private void SetIncludedMonths()
        {
            // Get the months requested to filter the data
            includedMonths = new List<int>();
            if (fromMonth.SelectedIndex < toMonth.SelectedIndex)
            {
                for (int i = fromMonth.SelectedIndex + 1; i <= toMonth.SelectedIndex + 1; i++)
                    includedMonths.Add(i);
            }
            else
            {
                for (int i = fromMonth.SelectedIndex + 1; i <= 12; i++)
                    includedMonths.Add(i);
                for (int i = 1; i <= toMonth.SelectedIndex + 1; i++)
                    includedMonths.Add(i);
            }
        }
    }
}
