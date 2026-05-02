using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wiersz");
           int wiersz = int.Parse(Console.ReadLine());
     
            for(int i = 0; i < wiersz; i++)
            {
                for(int j = 0; j < wiersz; j++)
                Console.Write("*");
                Console.WriteLine();
            }
            Console.ReadKey();
            /*double j = 50;
            double k = 40;
            double i = 0;
            int d = 0;
            do
            {
                 i += 0.2 * j + k * 0.2;
                d++;
                Console.WriteLine("Dzien {0}, splata {1}", d, i);
            } while (i < 80);
            Console.ReadKey();
            /*do
            {
                 j += 10;
                 k += 8;
                ++i;
                Console.WriteLine("Dzien {0}, Janek {1}, Karol {2}",i,j,k);
            } while ( k < 80);
            Console.ReadKey();
           /* Console.WriteLine("podaj 1 liczbe calkowita");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("podaj 2 liczbe calkowita");
            int b = int.Parse(Console.ReadLine());
            
            /*if (a <= b)
            {
                for (int c = a; c <= b; c++)
                    if (c % 2 == 0)
                    {
                        Console.Write(c + ",");
                    }
            }
            Console.ReadKey();
            /* Console.WriteLine("podaj l calkowita");
             int liczba = int.Parse(Console.ReadLine());
             if (liczba % 2 == 0)
                 Console.WriteLine("{0} jest liczba parzysta", liczba);
             else
                 Console.WriteLine("{0} jest liczba nieparzysta", liczba);

             if (liczba < 0)
                 Console.WriteLine("{0} jest ujemna", liczba);
             else
             Console.WriteLine( "{0} jest dodatnia", liczba );

             Console.ReadKey();
             */

        }
    }
}
