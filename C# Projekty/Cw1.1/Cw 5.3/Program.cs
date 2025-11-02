using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw_5._3
{
    internal class Program
    {
        
            static int[] Nieparzysta(int[] L)
            {
               int[] tab = new int[L.Length];
                for (int i = 0; i < L.Length; i++)
                    if (L[i] % 2 == 0)
                        tab[i] = L[i];
                return tab;
            }
            static void Main(string[] args)
            {
                Random rnd = new Random();
                int[] L = new int[4];

                for (int i = 0; i < L.Length; i++)
                    L[i] = rnd.Next(1,100);
                foreach (int i in Nieparzysta(L))
                    Console.WriteLine(i);
                Console.ReadKey();
            }
        
    }
}
