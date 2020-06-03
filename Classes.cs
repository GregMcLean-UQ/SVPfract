using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVPfract
{
    class HourlyData
    {
        double latitude;
        public List<HourlyRecord> hourlyRecords;
        public HourlyData(double _latitude)
        {
            latitude = _latitude;
            hourlyRecords = new List<HourlyRecord>();
        }
    }
    class HourlyRecord      // hourly data from file
    {
        double RH;
        public double radiation;
        public double temperature;
        public double svp;
        public double vpd;
        public DateTime dateTime;
        public int doy;
        public HourlyRecord(string line)
        {
            /*
             * Year,Month,Day,Hour,RH,RADN,Temperature
                2019,1,1,0,59.41666667,1,3.627777778

             */
            var items = line.Split(',').ToList();
            List<Int32> dateInts = items.GetRange(0, 4).Select(int.Parse).ToList();
            dateTime = new DateTime(dateInts[0], dateInts[1], dateInts[2], dateInts[3], 0, 0);
            doy = dateTime.DayOfYear;
            RH = Convert.ToDouble(items[4]);
            radiation = Convert.ToDouble(items[5]);
            temperature = Convert.ToDouble(items[6]);
            svp = 6.1078 * Math.Exp(17.269 * temperature / (237.3 + temperature)) * 0.1;
            vpd = svp - svp * RH / 100;

        }
    }
    class DailyRecord       // daily maxT, minT, and avgVPD during daylight hours
    {
        DateTime dateTime;
        public double avgVPD;
        public double predVPD;
        public double svpMaxT, svpMinT;
        private DateTime dt;

        public DailyRecord(DateTime dt, double avgVPD, double svpMaxT, double svpMinT)
        {
            this.dt = dt;
            this.avgVPD = avgVPD;
            this.svpMaxT = svpMaxT;
            this.svpMinT = svpMinT;
        }
        public void CalcPredVPD(Double spvFract)
        {
            predVPD = (svpMaxT - svpMinT) * spvFract;
        }
    }
}
