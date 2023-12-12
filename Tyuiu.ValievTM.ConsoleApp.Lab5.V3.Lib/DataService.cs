using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.ValievTM.ConsoleApp.Lab5.V3.Lib
{
    public class DataService
    {
        public double GetSum (int n)
        {
            double S=0;
            for (int x = 1; x <= n; x++)
            {
                S = S + ((x * x - Math.Cos(x * x)) / (x * x - Math.Sin(x * x)));
            }
            return Math.Round(S,3);


        }
    }
}
