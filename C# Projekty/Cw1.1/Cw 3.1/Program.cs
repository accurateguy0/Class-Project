using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw_3._1
{
    internal class Program
    {
        static string Najmniejsza(int a, int b, int c)
        {
            if (a < b && a < c)
                return "a jest najmniejsza";
            else if (b < a && b < c)
                return "b jest najmniejsza";
            else
                return "c jest najmniejsza";
        }
        static void Main(string[] args)
        {
            int a = 1; int b = 2; int c = 3;
            Console.WriteLine(Najmniejsza(a, b, c));
            Console.ReadKey();
            
        }
    }
}
