﻿using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KhakimovDKh.Sprint3.Task2.V29.Lib
{
    public class DataService : ISprint3Task2V29
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double SumSeries = 0;
            do
            {
                SumSeries = SumSeries + ((Math.Pow(value, startValue) + 0.25) * Math.Cos(startValue));
                startValue++;
            } while (startValue <= stopValue);
            return Math.Round(SumSeries, 3);
        }
    }

   
}
