using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._1
{
    internal class Program
    {
        static double Temp(double F)
        {
            double C = (F - 32) * 5 / 9;
            return (C);
        }
        static void Main(string[] args)
        {
            double F;
            Console.WriteLine("podaj fahrenheita");
            F = Double.Parse(Console.ReadLine());
            Console.WriteLine(Temp(F));
            Console.ReadKey();
        }
    }
}
