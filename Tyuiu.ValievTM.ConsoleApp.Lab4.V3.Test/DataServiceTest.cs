﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tyuiu.ValievTM.ConsoleApp.Lab4.V3.Lib
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetPoint()
        {
            DataService ds = new DataService();
            double x = 0;
            double y = 0;
            bool res = ds.GetPointShape(x, y);
            bool wait = true;
            Assert.AreEqual(wait, res);

        }
    }
}
