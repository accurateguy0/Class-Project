using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("podaj liczbe a");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("podaj liczbe b");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("podaj 3 liczbe c");
            double c = double.Parse(Console.ReadLine());
            double d = Math.Pow(b, 2) - 4 * a * c;
            double e = (-b - -d)/2*a;
            double f = (-b - d) / 2*a;
            Console.WriteLine(e + " " + f);
            Console.ReadKey();
        }
    }
}
