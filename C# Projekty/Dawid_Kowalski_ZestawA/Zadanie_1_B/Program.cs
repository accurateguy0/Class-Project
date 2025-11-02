using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_1_B
{
    internal class Program
    {
        static void MEtoda1(int n)
        {
            int i = n;
            while (i > 0)
            {
                int j = 1;
                while (j <= i)
                {
                    while (j <= i & j % 3 == 1)
                    {
                        Console.Write("*");
                        j++;
                    }
                    while (j <= i & j % 3 == 2)
                    {
                        Console.Write("#");
                        j++;
                    }
                    while (j <= i & j % 3 == 0)
                    {
                        Console.Write("+");
                        j++;
                    }
                }
                Console.WriteLine();
                i--;
            }

        }
        static void Main(string[] args)
        {
            MEtoda1(6);
            Console.ReadKey();
        }
    }
}
