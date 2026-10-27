using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.TinkovSS.Sprint3.Task1.V5.Lib
{
    public class DataService : ISprint3Task1V5
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double multSeries = 1.0;
            int k = startValue;

            while (k <= stopValue)
            {
                multSeries *= Math.Cos(0.1) + Math.Pow(k, -2);
                k++;
            }

            return Math.Round(multSeries, 3);
        }
    }
}