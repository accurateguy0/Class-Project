using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw1._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("podaj a");
            double a = int.Parse(Console.ReadLine());
            Console.WriteLine("podaj b");
            double b = int.Parse(Console.ReadLine());
            double srednia = (a + b) / 2;
            Console.WriteLine("srednia dwoch liczb to: " + srednia);
            Console.ReadKey();
        }
    }
}
