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

            // Get the months requested to filter the data
            List<int> includedMonths = new List<int>();
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

            for (DateTime dt = firstDay; dt <= lastDay; dt = dt.AddDays(1))
            {
                try
                {
                    var dayData = from x in hourlyData.hourlyRecords where (x.dateTime.Date == dt && includedMonths.Contains(x.dateTime.Month)) select x;
                    var avgVPD = (from y in dayData where y.radiation > radnThreshold select y.vpd).Average();
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
        #region
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

            //ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
            //ContextMenuStrip menuStrip = (ContextMenuStrip)menuItem.GetCurrentParent();
            //Chart cht = (Chart)(menuStrip.SourceControl);
            //string chartName = cht.Name;

            List<string> lines = new List<string>();
            foreach (DataPoint pt in chart.Series["Data"].Points)
            {
                string line = pt.XValue.ToString("F4") + "," + pt.YValues[0].ToString("F4");
                lines.Add(line);
            }
            File.WriteAllLines(csvFileName, lines);

            //List<string> lines = new List<string>();
            //if (chartName == "boxPlot")
            //{
            //    // header
            //    List<string> header = new List<string>();
            //    foreach (DataGridViewColumn col in dataGrid.Columns)
            //        header.Add(col.HeaderText);
            //    lines.Add(String.Join(",", header.ToArray()));

            //    foreach (DataGridViewRow row in dataGrid.Rows)
            //    {
            //        if (!(bool)row.Cells["Selected"].Value) continue;
            //        // header
            //        List<string> levels = new List<string>();
            //        for (int i = 0; i < dataGrid.ColumnCount; i++)
            //            levels.Add(row.Cells[i].Value.ToString());

            //        lines.Add(String.Join(",", levels.ToArray()));
            //    }

            //}
            //else if (chartName == "optChart")
            //{

            //    lines.Add("Risk,Yield,Site,RowConfiguration,Population,Planting,RootAngle");

            //    foreach (DataPoint pt in optChart.Series["GxM"].Points)
            //    {
            //        string line = pt.XValue.ToString("F0") + " " + pt.YValues[0].ToString("F0") + " " + pt.ToolTip;
            //        line = line.Replace(' ', ',');
            //        lines.Add(line);
            //    }


            //}

            //else if (chartName == "diffChart")
            //{
            //    int chartIndx = Convert.ToInt32(groupBox.Tag);
            //    switch (chartIndx)
            //    {
            //        case 0:
            //            lines.Add("Yield,Difference");
            //            break;
            //        case 1:
            //            lines.Add("Yield,Difference%");
            //            break;
            //        case 2:
            //            lines.Add("Year,Difference");
            //            break;
            //    }
            //    if (chartIndx == 2)      // time series
            //    {
            //        foreach (DataPoint pt in diffChart.Series["Time"].Points)
            //        {
            //            string line = pt.XValue.ToString("F0") + "," + pt.YValues[0].ToString("F0");
            //            lines.Add(line);
            //        }
            //    }
            //    else
            //    {
            //        foreach (DataPoint pt in diffChart.Series["GxM"].Points)
            //        {
            //            string line = pt.XValue.ToString("F1") + "," + pt.YValues[0].ToString("F1");
            //            lines.Add(line);
            //        }
            //    }
            //}



            //File.WriteAllLines(csvFileName, lines);

            /*
             * int ptIndx = optChart.Series["GxM"].Points.AddXY((double)p.X, (double)p.Y);
               optChart.Series["GxM"].Points[ptIndx].ToolTip = string.Join(" ", levels);
               optChart.Series["GxM"].Points[ptIndx].Color = colorList[colourIndx];
             * */
        }

        #endregion

    }
}
