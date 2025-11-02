using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw_4._5
{
    internal class Program
    {
        static bool Rosnaco(params int[] tab)
        {
            int roznica;
            int l = tab[0];
            bool b = false;
            for (int i = 1; i < tab.Length-1; i++)
            {
                roznica = tab[i];
                l = l + roznica;
                if (tab[i] > tab[i + 1])
                {
                    Console.WriteLine("nie jest rosnaca");
                    break;
                }
                else
                    b = true;   
                    

            }
            return b;
        }
        static void Main(string[] args)
        {
            int[] tab = new int[] { 1, 2, 3 };
            Rosnaco(tab);
            if (Rosnaco(tab))
                Console.WriteLine("jest rosnaca");
            Console.ReadKey();
        }
    }
}
