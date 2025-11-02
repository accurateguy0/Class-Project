using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw_6._2
{
    internal class Program
    {
        static char[] Insert(char[] t1, char[] t2)
        {
            int n = 7;
            
            char[] tab = new char [t1.Length + t2.Length];
            for (int i = 0; i < n; i++)
                tab[i] = t1[i];
            for (int i = 0; i < t2.Length; i++)
                tab[i + n] = t2[i];
            for (int i = 0; i < t1.Length - n ; i++)
                tab[t2.Length + n + i] = t1[i + n];
            return tab;


        }
        static void Main(string[] args)
        {
            char[] tekst1 = { 'a', 'l', 'a', ' ', 'm', 'a', ' ', 'k', 'o', 't', 'a' };
            char[] tekst2 = { 'k', 'a', 'n', 'a', 'r', 'k', 'a', ' ', 'i', ' ' };

            Console.WriteLine(Insert(tekst1, tekst2));
            Console.ReadKey();
        }

    }
}
