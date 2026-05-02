using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj temperature C");
            double C = double.Parse(Console.ReadLine());
            double F = 32 + 9.0 / 5 * C;
            Console.WriteLine(F);
            Console.ReadKey();
        }
    }
}
