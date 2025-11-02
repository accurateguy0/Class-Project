using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadnie_3_B
{
    internal class Program
    {
        static char[] Metoda3(char[] tab)
        {
            int i = 0; 
           
                do
                {
                int k = tab[i] + 32;
                tab[i] = (char)k;
                do
                  {
                       ++i;
                    Console.WriteLine(i);
                } while (tab[i] > 91 & i < tab.Length - 1);
                
            } while ( i < tab.Length - 1);
            return tab;
        }
        static void Main(string[] args)
        {
            char[] tab1 = { 'A', 'l', 'a', 'h' };
            Console.Write(Metoda3(tab1));
            Console.ReadKey();
        }
    }
}
