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
    public class Stats
    {
        //---------------------------------------------------------------------------
        // Description: Returns the sum of an array
        //---------------------------------------------------------------------------
        public double calcSum(double[] arr)
        {
            double sum = 0.0;
            foreach (double f in arr)
            {
                sum += f;
            }
            return sum;
        }
        //---------------------------------------------------------------------------
        // Description: 
        //---------------------------------------------------------------------------
        public double calcMax(double[] arr)
        {
            double[] sortVals = sortArray(arr);
            return sortVals[sortVals.Length - 1];
        }
        //---------------------------------------------------------------------------
        // Description: 
        //---------------------------------------------------------------------------
        public double calcMin(double[] arr)
        {
            double[] sortVals = sortArray(arr);
            return sortVals[0];
        }
        //---------------------------------------------------------------------------
        // Description: Returns the mean of an array
        //---------------------------------------------------------------------------
        public double calcMean(double[] arr)
        {
            return (calcSum(arr) / arr.Length);
        }
        //---------------------------------------------------------------------------
        // Description: Returns the median of an array
        //---------------------------------------------------------------------------
        public double calcMedian(double[] arr)
        {
            double median;

            //Create a working array
            double[] workArr = sortArray(arr);

            //Calc median if the size of the array of years is even
            if (arr.Length % 2 == 0)
            {
                double totalMed = workArr[(arr.Length / 2) - 1] + workArr[(arr.Length / 2)];
                median = totalMed / 2;
            }
            else
            {
                median = workArr[((arr.Length + 1) / 2) - 1];
            }

            return median;
        }
        //---------------------------------------------------------------------------
        // Description: Returns the median of an array
        //---------------------------------------------------------------------------
        public List<double> calcMedian(double[] arr, double[] arr2)
        {
            //arr2 is a dependent array - if we want the median of the first array and the corresponding values
            //in the dependent array - not necessarily th e median of the dependent array
            if (arr.Length != arr2.Length)
            {
                throw new Exception("Arrays are not the same length");
            }

            List<double> median = new List<double>();

            //Create a working array
            double[] workArr = new double[arr.Length];
            double[] workArr2 = new double[arr.Length]; //Should be the same length

            arr.CopyTo(workArr, 0);
            arr2.CopyTo(workArr2, 0);

            sortArray(workArr, workArr2);
            //Calc median if the size of the array of years is even
            if (arr.Length % 2 == 0)
            {
                //Calculate median for the primary array
                double totalMed = workArr[(arr.Length / 2) - 1] + workArr[(arr.Length / 2)];
                median.Add(totalMed / 2);
                //Calculate median for the dependent array
                totalMed = workArr2[(arr.Length / 2) - 1] + workArr2[(arr.Length / 2)];
                median.Add(totalMed / 2);
            }
            else
            {
                //Add median for the primary array
                median.Add(workArr[((arr.Length + 1) / 2) - 1]);
                //Add median for the dependent array
                median.Add(workArr2[((arr.Length + 1) / 2) - 1]);
            }

            return median;
        }
        //---------------------------------------------------------------------------
        // Description: Sorts an array from lowest to highest
        //---------------------------------------------------------------------------
        public double[] sortArray(double[] arr)
        {
            double[] sorted = new double[arr.Length];
            arr.CopyTo(sorted, 0);
            double temp;

            //Bubblesort array
            for (int i = (sorted.Length - 1); i >= 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (sorted[j] > sorted[j + 1])
                    {
                        temp = sorted[j];
                        sorted[j] = sorted[j + 1];
                        sorted[j + 1] = temp;
                    }
                }
            }
            return sorted;
        }
        //---------------------------------------------------------------------------
        public void sortArray(double[] arr, double[] arr2)
        {
            //arr2 is the dependent array so what we do to the first one we do to the second
            double temp;
            //Bubblesort array
            for (int i = (arr.Length - 1); i >= 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;

                        //Repeat to the dependent array
                        temp = arr2[j];
                        arr2[j] = arr2[j + 1];
                        arr2[j + 1] = temp;
                    }
                }
            }
        }

        //---------------------------------------------------------------------------
        // Description: Returns the Regression parameters for two given arrays
        //---------------------------------------------------------------------------
        public void calcRegression(double[] x, double[] y, out double slope, out double intercept, out double rsq)
        {

            rsq = calcRsq(x, y);

            //Calc the means
            double meanX = calcMean(x);
            double meanY = calcMean(y);

            //calc the std devs
            double stDevX = calcStDev(x, meanX);

            //calc the co-variance
            double coVarXY = calcCoVar(x, meanX, y, meanY);

            slope = coVarXY / Math.Pow(stDevX, 2);

            intercept = (-1 * slope * meanX) + meanY;
        }

        //---------------------------------------------------------------------------
        // Description: Returns the Rsq between two arrays
        //---------------------------------------------------------------------------
        public double calcRsq(double[] obs, double[] pred)
        {
            //Calc the means
            double meanObs = calcMean(obs);
            double meanPred = calcMean(pred);
            //calc the std devs
            double stDevObs = calcStDev(obs, meanObs);
            double stDevPred = calcStDev(pred, meanPred);
            //calc the co-variance
            double coVar = calcCoVar(obs, meanObs, pred, meanPred);
            //Calc r
            double r = coVar / (stDevPred * stDevObs);

            return (double)Math.Pow(r, 2);
        }
        //---------------------------------------------------------------------------
        // Description: Returns the standard deviation of an array given only the array
        //---------------------------------------------------------------------------
        public double calcStDev(double[] arr)
        {
            double meanArr = calcMean(arr);

            return calcStDev(arr, meanArr);
        }
        //---------------------------------------------------------------------------
        // Description: Returns the standard deviation of an array given the array and 
        //              its mean
        //---------------------------------------------------------------------------
        public double calcStDev(double[] arr, double meanArr)
        {
            double tot = 0.0;
            for (int i = 0; i < arr.Length; i++)
            {
                tot = tot + (double)Math.Pow((arr[i] - meanArr), 2);
            }

            return (double)Math.Sqrt((tot / arr.Length));
        }
        //---------------------------------------------------------------------------
        // Description: Calculates the co-variance between two arrays given only the 
        //              arrays
        //---------------------------------------------------------------------------
        public double calcCoVar(double[] x, double[] y)
        {
            double meanX = calcMean(x);
            double meanY = calcMean(y);

            return calcCoVar(x, meanX, y, meanY);
        }
        //---------------------------------------------------------------------------
        // Description: Calculates the co-variance between two arrays given the 
        //              arrays and their means
        //---------------------------------------------------------------------------
        public double calcCoVar(double[] x, double meanX, double[] y, double meanY)
        {
            double tot = 0.0;
            double sX, sY;
            for (int i = 0; i < x.Length; i++)
            {
                sX = x[i] - meanX;
                sY = y[i] - meanY;

                tot += (sX * sY);
            }

            return (tot / x.Length);
        }
        //---------------------------------------------------------------------------
        public double[] calcCDF(int length)
        {
            double[] percentiles = new double[length];

            //Create the percentile array
            percentiles[0] = 0.0;
            percentiles[length - 1] = 1.0;

            for (int i = 1; i < (percentiles.Length - 1); i++)
            {
                percentiles[i] = (1 / ((double)percentiles.Length - 1)) * i;
            }
            return percentiles;
        }
    }

}
