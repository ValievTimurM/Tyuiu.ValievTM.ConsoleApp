using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ValievTM.ConsoleApp.Lab2.V3.Lib;

namespace Tyuiu.ValievTM.ConsoleApp.Lab2.V3.Test
{
  [TestClass]
  public class DataServiceTest
  {
    [TestMethod]
    public void ValidExpressionV_11_1()
    {
      double x = 2;
      double y = -5;
      DataService ds = new DataService();

      double result = ds.SolveExpressV_11_1(x, y);

      result = Math.Round(result, 15);
      double wait = -12.887505536756105;

      Assert.AreEqual(result, wait);
    }

    [TestMethod]
    public void ValidExpressionV_11_2()
    {
      double x = -2;
      double y = 4;
      DataService ds = new DataService();

      double result = ds.SolveExpressV_11_2(x, y);

      result = Math.Round(result, 14);
      double wait = -35.938157612696322;

      Assert.AreEqual(result, wait);
    }
  }
}
