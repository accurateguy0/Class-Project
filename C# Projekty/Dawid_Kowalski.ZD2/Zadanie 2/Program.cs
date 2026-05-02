using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "Sprawdzanie czy jedna z 3 liczb calkowitych jest suma 2 pozostalych. Podaj a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Podaj b");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Podaj c");
            int c = Convert.ToInt32(Console.ReadLine());
            if (a + b == c)
            {
                Console.WriteLine("Liczba c jest suma pozostalych dwoch liczb ");
            }
            else if (a + c == b)
            {
                Console.WriteLine("Liczba b jest suma pozostalych dwoch liczb ");
            }
            else if (b + c == a)
            {
                Console.WriteLine("Liczba a jest suma pozostalych dwoch liczb ");
            }
            else
            {
                Console.WriteLine("Zadna liczba nie jest suma pozostalych dwoch liczb ");
            }
            Console.ReadKey();
        }
    }
}
