using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.VisualStyles;

namespace SVPfract
{
    public partial class SPVfractForm : Form
    {

        public List<double> calcTemperature(double latitude, double doy, double tMax, double tMin, double minLag, double maxLag, double nightCoef)
        {
            var temperature = new List<double>();
            // A Model for Diurnal Variation in Soil and Air Temperature
            // William J. Parton and Jesse A. Logan : Agricultural Meteorology, 23 (1991) 205-216
            // with corrections

            double latR = Math.PI / 180.0 * latitude;      // convert latitude (degrees) to radians

            double aDelt = 0.4014 * Math.Sin(2 * Math.PI * (doy - 77.0) / 365.0);
            double temp1 = 1.0 - Math.Pow(-Math.Tan(latR) * (aDelt), 2.0f);
            temp1 = Math.Sqrt(temp1);
            double temp2 = (-Math.Tan(latR) * Math.Tan(aDelt));
            double aHou = Math.Atan2(temp1, temp2);
            double ady = (aHou / 3.14) * 24.0;             // day hours
            double ani = (24.0 - ady);                     // night hours
                                                           // determine if the hour is during the day or night
            double bb = 12.0 - ady / 2.0 + minLag;              // corrected dawn
            double be = 12.0 + ady / 2.0;                  // sundown

            for (int hr = 1; hr <= 24; hr++)
            {
                double bt = hr;
                double bbd = 0;
                double tempr;
                if (bt >= bb && bt < be)         //day
                {
                    bbd = bt - bb;
                    tempr = (tMax - tMin) * Math.Sin((3.14 * bbd) / (ady + 2 * maxLag)) + tMin;
                }
                else                             // night
                {
                    if (bt > be) bbd = bt - be;
                    if (bt < bb) bbd = (24.0 - be) + bt;
                    double ddy = ady - minLag;
                    double tsn = (tMax - tMin) * Math.Sin((3.14 * ddy) / (ady + 2 * maxLag)) + tMin;
                    tempr = tMin + (tsn - tMin) * Math.Exp(-nightCoef * bbd / ani);
                }
                temperature.Add(tempr);
            }
            return temperature;
        }
        private List<double> Optimise()
        {
            // For each day of the month, evaluate the calcTemperature function for a range of the three variables.
            // compare the hourly temperatures with the observed and get a sum of the squares of the differences
            // and select the minimum. store the day of the month and the values.

            double latitude = Convert.ToDouble(latTextBox.Text);

            // For every day in the month selected get the hourly temperature
            int selectedMonth = fromMonth.SelectedIndex + 1;
            var dayData = from x in hourlyData.hourlyRecords where (x.dateTime.Month == selectedMonth) select x;

            List<double> minLag = new List<double>() { 0.1, 0.2, 0.3, 0.5, 1.5, 2.0, 2.5, 3.0, 3.5 };
            List<double> maxLag = new List<double>() { 2.0, 2.2, 2.3, 2.4, 2.6, 2.8, 3.0, 3.5, 4.0, 4.5, 5.0 };
            List<double> nightCoef = new List<double>() { 1.0, 2.0, 3.0, 4.0, 5.0, 6.0 };

            List<double> estMinLags = new List<double>();
            List<double> estMaxLags = new List<double>();
            List<double> estNightCoefs = new List<double>();

            double bestX = 0;
            double bestY = 0;
            double bestZ = 0;

            for (int doy = dayData.First().doy; doy <= dayData.Last().doy; doy++)
            {
                var hourData = (from x in hourlyData.hourlyRecords where (x.doy == doy) select x.temperature).ToList();
                //Convert to solar time. Move back 1 hour.
                hourData.Add(hourData.First());hourData.RemoveAt(0);



                double maxT = hourData.Max();
                double minT = hourData.Min();

                double minSSD = 999999;
                bestX = 0;
                bestY = 0;
                bestZ = 0;

                foreach (double x in minLag)
                {
                    foreach (double y in maxLag)
                    {
                        foreach (double z in nightCoef)
                        {
                            var estHourly = calcTemperature(latitude, doy, maxT, minT, x, y, z);
                            // Estimated values are about solar noon which is 1PM. so move est one hour to right
                            // Move first to flast to allow for solar noon DEBUG
                           // double lastVal = estHourly.Last(); estHourly.Insert(0, lastVal); estHourly.RemoveAt(estHourly.Count - 1);
                            double ssd = CalcSSD(estHourly, hourData);
                            if (ssd < minSSD)
                            {
                                minSSD = ssd;
                                bestX = x; bestY = y; bestZ = z;
                            }
                        }
                    }
                }
                estMinLags.Add(bestX);
                estMaxLags.Add(bestY);
                estNightCoefs.Add(bestZ);
            }
            // Now do stats on the estimations
            Stats stats = new Stats();
            List<double> parameters = new List<double>();
            parameters.Add(estMinLags.Average());
            parameters.Add(estMaxLags.Average());
            parameters.Add(estNightCoefs.Average());
            parameters.Add(stats.calcStDev(estMinLags.ToArray()));
            parameters.Add(stats.calcStDev(estMaxLags.ToArray()));
            parameters.Add(stats.calcStDev(estNightCoefs.ToArray()));
            return parameters;
        }
        private double CalcSSD(List<double> estHourly, List<double> hourData)
        {
            double ssd = 0.0;
            for (int i = 0; i < estHourly.Count; i++)
            {
                ssd += Math.Pow((estHourly[i] - hourData[i]), 2);
            }


            return ssd;
        }

    }
}
