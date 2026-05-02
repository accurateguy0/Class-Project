using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tekst = "Ala ma kota";
            foreach (char litera in tekst)
                Console.WriteLine(litera);
            Console.ReadKey();
            /* int[] uczestnicy = {19, 34, 23, 44, 13 };
             int max;
             foreach (int i in uczestnicy)
                 if (i > max)
                 max = i;


             Console.WriteLine(max);
              int suma = 0;
              int[] uczestnicy = { 19, 34, 23, 44, 13 };
              foreach (int x in uczestnicy)
              {
                  Console.WriteLine(suma);
                   suma += x;
              }
              double srednia = (double)suma/uczestnicy.Length;
              Console.WriteLine("srednia wynosi: " + srednia);*/
            Console.ReadKey();
        }
    }
}
