using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tyuiu.ValievTM.ConsoleApp.Lab1.V1.Lib
{
  public class DataService
  {
    public double SolveExpressV_11_1(double x, double y, double a)
    {
      double result = 4 * x + (((a + 3) / y) / ((3 * x + a) / (x - 2))) * ((2 + y + x - 3 * a) / (x - 7 * y));
      return result;
    }

    public double SolveExpressV_11_2(double x, double y, double a)
    {
      double result = 12 * y - ((3 * x + 2 * a + a) / (3 * a + 2 * x - y)) + 12 * y + ((a / (y + 2)) / (4 * a / x));
      return result;
    }
  }
}
