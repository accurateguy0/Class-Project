using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw_4._2
{
    internal class Program
    {
        static void Trojkat(int n)
        {
            //for (int i = n; i > 0; i--)
            //{
            //    for (int j = 0; j < i; j++)
            //        Console.Write("*");
            //    Console.WriteLine();
            //}
            int m = n;
            do
            {
                 n = m;
                while (n > 0)
                {
                    Console.Write("*");
                    n--;    
                }
                Console.WriteLine();
                m--;
            } while (m > 0);
               
        }
        static void Main(string[] args)
        {
            Console.WriteLine("podaj n dodatnie");
            int n = int.Parse(Console.ReadLine());
            Trojkat(n);
            Console.ReadKey();
        }
    }
}
