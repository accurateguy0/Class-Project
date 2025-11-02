using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw._4._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 3, m = 7;
            int i = 100;
            int k;
            int s;
            while ( i <= 999)
            {
                 s = 0;
                 k = i;
                
                while (k > 0)
                {
                    s = s + k % 10;
                    k = k / 10;


                   
                   
                }
                if (s % n == 0 && s % m == 0)
                    Console.WriteLine(i);
                i++;
            }
           

            Console.ReadKey();
        }
    }
}
