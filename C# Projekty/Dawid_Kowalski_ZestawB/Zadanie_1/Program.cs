using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_1
{
    internal class Program
    {
        static void Metoda1(int n)
        {
            int i = n;
            int k = n;
            int l = 1;
            while (i > 0)
            {
                int j = 1;
                while(j <= k)
                {
                  
                        Console.Write("*");
                        j++;
                    while ( j % 3 == 2 & j <= k)
                    {
                        Console.Write("+");
                        j++;
                       
                    }
                    while ( j % 3 == 0 & j <= k)
                    {
                        Console.Write("#");
                        j++;
                       
                    }
                   
                }
                Console.WriteLine();
                k--;
                i--;
            }
        }
        static void Main(string[] args)
        {
            Metoda1(6);
            Console.ReadKey();
        }
    }
}
