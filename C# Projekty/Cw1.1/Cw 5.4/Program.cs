using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw_5._4
{
    internal class Program
    {
        static void Najw( ref int a, int[]tab)
        {
            int b = tab[0];
            for (int i = 0; i < tab.Length; i++) 
                if (tab[i] > b)
                    b = tab[i];
            for (int i = 0;i < tab.Length; i++)
                if (b == tab[i])
                    a++;

        }
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] tab = new int [10];
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = rnd.Next(1, 10);
            }
            foreach (int i in tab)
                Console.Write(i + " ");
            int ilosc = 0;
            Najw(ref ilosc, tab);
            Console.WriteLine("najwieksza liczba sie powtorzyla {0} razy", ilosc);
            Console.ReadKey();
        }
    }
}
