using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tyuiu.ValievTM.ConsoleApp.Lab4.V3.Lib
{
    public class DataService
    {
        public bool GetPointShape(double x, double y)
        {
            bool res;
            if ((Math.Pow(x, 2) + (Math.Pow((y - 1), 2)) <= 1) && (y<=1- Math.Pow(x, 2))) 
                
            {
                res = true;
                
            }

            else
            {
                res = false;
            }

            return res;
        }
    }
}
