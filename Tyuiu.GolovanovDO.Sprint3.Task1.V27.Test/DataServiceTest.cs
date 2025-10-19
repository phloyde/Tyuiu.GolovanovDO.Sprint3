﻿using Newtonsoft.Json.Linq;
using Tyuiu.GolovanovDO.Sprint3.Task1.V27.Lib;
namespace Tyuiu.GolovanovDO.Sprint3.Task1.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double value = 0.75;
            int startValue = 1;
            int stopValue = 5;

            double res = ds.GetMultiplySeries(value, startValue, stopValue);
            Assert.AreEqual(419028.1, res);
        }
    }
}
