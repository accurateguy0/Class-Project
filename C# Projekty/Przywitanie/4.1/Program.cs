using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("tablica jednowymiarowa. podaj wymiar n,");
            int n = int.Parse(Console.ReadLine());
            int[] tab = new int[n];
            Console.WriteLine("podaj " +n+ "elementow tablicy.");
            for (int i = 0; i < n; i++)
            {
                tab[i] = int.Parse(Console.ReadLine()) ;
                if(i == n-1)
                foreach (int x in tab)
                    Console.Write(x +",");
            }
         Console.ReadKey();
        }
    }
}
