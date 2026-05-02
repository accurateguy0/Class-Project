using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._14_zad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("podaj N .liczba doskonala ");
            int N = int.Parse(Console.ReadLine());
            int n = 1;
            int m = 1;
            int i = 0;
            while (N >= n)
            {


                while (n % m == 0 && ((n != m) || n == 1)) //filtr dzielnikow nierownych n, z wyjatkiem 1
                {
                    i += m; // sumowanie dzielnikow
                    m++;  // inkrementacja dzielnika
                }
                 m++; //inkrementacje dzielnika w przypadku gdy konczy sie rekurencja
                if (n == i) // jesli suma dzielnikow rowna liczbie 
                {
                    Console.WriteLine(n + ","); // zapis l. doskonalej na tablicy
                    m = 1;
                    i = 0; // reset danych
                    n++;
                }
                else if (n <= m) //jesli dzielnik rowny od l. w zbiorze N
                {
                     m = 1;
                     i = 0; // tak samo z ta instrukcja
                     n++; // tu i tam dodajemy n, aby sprawdzac kolejne liczby
                }
            }
            Console.ReadKey();
        }
    }
}
