﻿





using  tyuiu.cources.programming.interfaces.Sprint3;


namespace Tyuiu.KhakimovDKh.Sprint3.Task5.V23.Lib
{
    public class DataService : ISprint3Task5V23
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double res = 0;
            double i, j;
            for (i = startValue1; i <= stopValue1; i++)
            {
                for (j = startValue2; j <= stopValue2; j++)
                {
                    res += ((Math.Pow(x, j) + 2) * (Math.Cos(j)));
                }
            }
            return Math.Round(res, 3);
        }
    }
}

