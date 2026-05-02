using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._15_zad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start");
            for (int z1 = 0; z1 <= 10; z1++)
                for (int z2 = 0; z2 <= 5; z2++)
                    for (int z5 = 0; z5 <= 2; z5++)
                        if (z1 * 1 + z2 * 2 + z5 * 5 == 10)
                            Console.WriteLine("zlotowka = {0} dwa zlote = {1} piec zlote = {2}", z1, z2, z5);
            Console.ReadKey();
            /*Console.WriteLine("Dysponując monetami 1 zł, 2 zł, 5 zł sprawdź, na ile różnych sposobów można \r\nwypłacić 10 zł.");
            int za = 1, zb = 2, n = 10, zc = 5, l = 0, a = 0, b = 0, c = 0;
            while ( c <= 2 )
            {
                l = a + b + c;
              if(n == l )
                {
                    while(a>)
                }
            }
            
            Console.ReadKey();*/
        }
    }
}
