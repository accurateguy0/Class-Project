using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 2147483640, b = 20000;
            int c = a + b;
            Console.WriteLine(c);
            Console.ReadKey(); // dla int nie przekracza liczba

        }
    }
}
