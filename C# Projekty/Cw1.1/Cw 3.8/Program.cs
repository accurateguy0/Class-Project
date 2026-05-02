using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw_3._8
{
    internal class Program
    {
        static int Suma(int n)
        {
            int s = 0;
            while (n > 0)
            {
                s = s + n;
                n--;
            }
            return s;
        }
        static void L(int k)
        {

            int s = 0;
            while (k > 0)
            {
                if (k % 2 != 0 | k % 3 != 0)
                   s = s + k;
                if (s % 7 == 0)
                    Console.Write(s + "  ");
                k--;
            }  
        }
        static void Main(string[] args)
        {
            int n = 10;
            Console.WriteLine(Suma(n));
            Console.WriteLine();
            L(500);
            Console.ReadKey();
        }
    }
}
