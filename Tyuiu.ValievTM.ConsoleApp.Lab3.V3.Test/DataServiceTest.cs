using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tyuiu.ValievTM.ConsoleApp.Lab3.V3.Lib
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
       public void ValidGetPoint()
        {
            DataService ds = new DataService();
            int x = 7;
            int y = 7;
            bool res = ds.GetPointShape(x, y);
            bool wait = true;
            Assert.AreEqual(wait, res);

        }
    }
}
