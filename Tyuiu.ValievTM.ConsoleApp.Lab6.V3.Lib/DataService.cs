using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.ValievTM.ConsoleApp.Lab6.V3.Lib
{
    public class DataService
    {
         public double [] GetMassFunction (int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x<=stopValue; x++)
            {
                if((Math.Pow(x, 3) - 15 * x) !=0)
                {
                    y = Math.Round(Math.Abs(Math.Pow(x, 2) - Math.Pow(x, 3)) - (Math.Cos(Math.Pow(x, 3)) + 7 * Math.Pow(x, 2)) / (Math.Pow(x, 3) - 15 * x), 2);
                    
                    valueArray[count] = y;
                    count++;
                }
                else
                {
                    count++;
                }
            }
            return valueArray;
        }
    }
}
