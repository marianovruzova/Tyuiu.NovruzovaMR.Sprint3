using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.NovruzovaMR.Sprint3.Task4.V22.Lib;

namespace Tyuiu.NovruzovaMR.Sprint3.Task4.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;

            double res = ds.Calculate(startValue, stopValue);

            double wait = -5.546;
            Assert.AreEqual(wait, res);
        }
    }
}