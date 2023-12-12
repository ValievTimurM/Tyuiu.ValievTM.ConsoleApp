using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ValievTM.ConsoleApp.Lab1.V1.Lib;

namespace Tyuiu.ValievTM.ConsoleApp.Lab1.V1.Test
{
  [TestClass]
  public class DataServiceTest
  {
    [TestMethod]
    public void ValidExpressionV_11_1()
    {
      double x = 5;
      double y = 3;
      double a = -4;
      DataService ds = new DataService();

      double result = ds.SolveExpressV_11_1(x, y, a);

      result = Math.Round(result, 5);
      double wait = 20.125;

      Assert.AreEqual(result, wait);

    }

    [TestMethod]
    public void ValidExpressionV_11_2()
    {
      double x = 5;
      double y = 3;
      double a = -4;
      DataService ds = new DataService();

      double result = ds.SolveExpressV_11_2(x, y, a);

      result = Math.Round(result, 5);
      double wait = 72.85;

      Assert.AreEqual(result, wait);

    }
  }
}
