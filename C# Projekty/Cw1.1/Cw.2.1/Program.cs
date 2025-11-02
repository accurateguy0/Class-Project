using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            int c = 3;
            if (a < b && a < c)
                Console.WriteLine("a jest najmniejsza");
            else if (b < a && b < c)
                Console.WriteLine("b jest najmniejsza");
            else Console.WriteLine("c jest najmniejsza");
            Console.ReadKey();
        }
    }
}
