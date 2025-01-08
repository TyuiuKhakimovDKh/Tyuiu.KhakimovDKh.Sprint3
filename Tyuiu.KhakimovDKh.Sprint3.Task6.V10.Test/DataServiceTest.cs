﻿
using Tyuiu.KhakimovDKh.Sprint3.Task6.V10.Lib;

namespace Tyuiu.KhakimovDKh.Sprint3.Task6.V10.Test
{


    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();

            int startValue = 20;
            int stopValue = 32;

            int res = ds.GetSumTheDivisors(startValue, stopValue);

            int wait = 396;

            Assert.AreEqual(wait, res);
        }
    }
}
