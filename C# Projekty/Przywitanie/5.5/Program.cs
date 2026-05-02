using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._5
{
    internal class Program
    {
        static void Rysuj(int dlugosc, int szerokosc, string znak)
        {
            for (int i = 0; i < szerokosc; i++)
            {
                for (int j = 0; j < dlugosc; j++)
                    Console.Write(znak);
                Console.WriteLine();
            }
                
        }
        static void Main(string[] args)
        {
            Console.WriteLine("podaj dlugosc");
            int dlugosc = int.Parse(Console.ReadLine());
            Console.WriteLine("podaj szerokosc");
            int szerokosc= int.Parse(Console.ReadLine());
            Console.WriteLine("podaj znak");
            string znak = Console.ReadLine();
            Rysuj(dlugosc, szerokosc, znak);
            Console.WriteLine();
            Rysuj(szerokosc, dlugosc, znak);
            Console.ReadKey();
        }
    }
}
