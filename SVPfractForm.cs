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
                    var dayData = from x in hourlyData.hourlyRecords where (x.dateTime.Date == dt && includedMonths.Contains( x.dateTime.Month))  select x;
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

            double slope, intercept, rsq;
            s.calcRegression(obsVPD.ToArray(), predVPD.ToArray(), out slope, out intercept, out rsq);
            chart.Series[1].Points.Clear();
            chart.Series[1].Points.AddXY(0, 0);
            double maxVal = obsVPD.Max();
            chart.Series[1].Points.AddXY(maxVal, maxVal * slope + intercept);
            TextAnnotation ta = new TextAnnotation();
            ta.Text = "";
            ((TextAnnotation)(chart.Annotations[0])).Text = "y = " + slope.ToString("F2") + "x + " +
                intercept.ToString("F2") + "\n rsq = " + rsq.ToString("F2") + " n = " + obsVPD.Count();
        }

    }
}
