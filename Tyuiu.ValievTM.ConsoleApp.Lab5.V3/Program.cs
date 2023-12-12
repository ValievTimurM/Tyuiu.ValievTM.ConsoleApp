using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ValievTM.ConsoleApp.Lab5.V3.Lib;
namespace Tyuiu.ValievTM.ConsoleApp.Lab5.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int n;
            double s;
            Console.WriteLine("Введите число N:");
            n = Convert.ToInt32(Console.ReadLine());
            s = ds.GetSum (n);
            Console.WriteLine("Конечная сумма равна " + s);
            Console.ReadKey();
        }
    }
}
