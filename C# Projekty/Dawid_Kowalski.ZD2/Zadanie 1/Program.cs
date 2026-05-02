using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Trojkat. Podaj a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Trojkat. Podaj b");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Trojkat. Podaj c");
            int c = Convert.ToInt32(Console.ReadLine());
            if (a + b > c)
            {
                Console.WriteLine("Da sie zbudowac trojkat z tych odcinkow ");
            }
             else if (a + c > b)
            {
                Console.WriteLine("Da sie zbudowac trojkat z tych odcinkow ");
            }
            else if (b + c > a)
            {
                Console.WriteLine("Da sie zbudowac trojkat z tych odcinkow ");
            }
            else
            {
                Console.WriteLine("Nie da sie zbudowac trojkat z tych odcinkow ");
            }
            Console.ReadKey();
        }
    }
}
