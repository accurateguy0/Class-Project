using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 10, b = 20;
            if (a > b)
                Console.WriteLine("a wieksze od b");
            if (a < b)
                Console.WriteLine("b wieksze od a");
            //Analogicznie
            //Console.WriteLine(Math.Max(a, b));
            Console.ReadKey();
        }
    }
}
