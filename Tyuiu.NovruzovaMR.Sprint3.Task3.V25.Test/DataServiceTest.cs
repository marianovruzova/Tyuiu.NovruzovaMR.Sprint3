using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.NovruzovaMR.Sprint3.Task3.V25.Lib;

namespace Tyuiu.NovruzovaMR.Sprint3.Task3.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string str = "kjhgfuu gujut dtuu";
            char chr = 'u';

            double res = ds.GetMinCharCount(str, chr);

            int wait = 4;
            Assert.AreEqual(wait, res);
        }
    }
}