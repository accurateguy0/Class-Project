using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            int k;
            int[] tab = new int[100];
            Random rand = new Random();
            for (int liczb = 0; liczb < 100; liczb++)
            {
                tab[liczb] = rand.Next(1, 1000);
                
               for ( k = 2; tab[liczb] > k; k++) 
                    if (tab[liczb] % k == 0)
               tab[liczb] = 0;
                if (tab[liczb] > 0)
                    suma += 1;

            }
            Console.WriteLine("suma liczb pierwszych to: {0}", suma);
                Console.ReadKey();
            
        }
    }
}
