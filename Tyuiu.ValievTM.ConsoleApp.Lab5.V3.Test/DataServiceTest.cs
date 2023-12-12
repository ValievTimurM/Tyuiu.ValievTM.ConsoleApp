using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tyuiu.ValievTM.ConsoleApp.Lab5.V3.Lib
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSum()
        {
            DataService ds = new DataService();
            int n=10;
            double s = ds.GetSum(n);
            double wait = 11.958;
            Assert.AreEqual(wait, s);



        }
    }
}
