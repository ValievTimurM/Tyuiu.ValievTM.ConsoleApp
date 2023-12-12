using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.ValievTM.ConsoleApp.Lab2.V3.Lib
{
  public class DataService
  {
    public double SolveExpressV_11_1(double x, double y)
    {
      double result = Math.Log(Math.Sin(x)) / Math.Log(1 + Math.Pow(x, 2)) + x * (y - Math.Sqrt(Math.Abs(x)));
      return result;
    }

    public double SolveExpressV_11_2(double x, double y)
    {
      double result = Math.Pow(y, x) / (Math.Cos(x) - (x / 3)) + ((Math.Sin(Math.Pow(x, 2)) + Math.Cos(y)) / (Math.Cos(x) - Math.Sin(y))) * Math.Tan(x) * y;
      return result;
    }

    public int RemoveDuplicates(int[] nums)
    {
      int k = 1;
      int firstEl = nums[0];
      for (int i = 1; i < nums.Length; i++)
      {
        if (nums[i] == firstEl) break;
        else
        {
          k++;
          firstEl = nums[i];
        }
      }
      return 0;
    }
  }
}