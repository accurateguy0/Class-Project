using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("podaj n naturalna ");
            int m = int.Parse(Console.ReadLine());
            int n = 0;
            Console.Write(" 0");
            for (int i = 1; i <= m; i++)
            {
                n += i;
                Console.Write(" + " + i);
                i++;
                if (i <= m)
                {
                    n -= i;
                    Console.Write(" - " + i);
                }

            }
            
            
            Console.Write("=" + n);
            Console.ReadKey();
        }
    }
}
