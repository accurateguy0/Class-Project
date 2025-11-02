using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj liczbę całkowitą. Czy jest podzielna przez 3?: ");
            int liczba = int.Parse(Console.ReadLine());

            if (liczba % 3 == 0)
            
                Console.WriteLine("Tak");
            
            else
            
                Console.WriteLine("Nie");
                Console.ReadKey();
            
        }
    }
}

