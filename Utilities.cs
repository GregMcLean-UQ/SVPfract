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

    }
}
