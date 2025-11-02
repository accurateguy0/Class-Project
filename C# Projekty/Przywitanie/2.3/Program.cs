using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj b");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj c");
            int c = int.Parse(Console.ReadLine());
            double delta = Math.Pow(b, 2) - 4*a*c;
            Console.WriteLine(delta);
            Console.ReadKey();
        }
    }
}
