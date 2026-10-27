using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.TinkovSS.Sprint3.Task4.V26.Lib
{
    public class DataService : ISprint3Task4V26
    {
        public double Calculate(int startValue, int stopValue)
        {
            double res = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0)
                {
                    continue;
                }

                res += (Math.Cos(x) - Math.Sin(x)) / (double)x;
            }

            return Math.Round(res, 3);
        }
    }
}