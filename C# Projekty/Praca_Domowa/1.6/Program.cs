using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 10, y = 20;
            double p = x * y;
            double a = 20, b = 20, c = 30, d = 40;
            double p1 = a * b;
            double p2 = d * c;
            if (p1 > p2)
            {
                Console.WriteLine("ab wieksze od cd");
            }
            if (p1 < p2)
            {
                Console.WriteLine("ab mniejsze od cd");
            }
            Console.ReadKey();
        }
    }
}
