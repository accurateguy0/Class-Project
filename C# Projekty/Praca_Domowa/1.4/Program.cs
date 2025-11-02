using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, y, z;
            Console.WriteLine("podaj x");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("podaj y");
            y = double.Parse(Console.ReadLine());
            Console.WriteLine("podaj z");
            z = double.Parse(Console.ReadLine());
            double a = (4 * x - y) / (3 * (z * z + 1));
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
