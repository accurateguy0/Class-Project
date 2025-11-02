using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw_6._1
{
    internal class Program
    {
        static char[] Concat(char[] t1, char[] t2)
        {
            char [] tab = new char[t1.Length + t2.Length];
            for (int i = 0; i < t1.Length; i++) 
                tab[i] = t1[i];
            for (int i = 0; i < t2.Length; i++) 
                tab[t1.Length + i] = t2[i];
            return tab;
        }
        static void Main(string[] args)
        {
            char[] tekst1 = { 'a', 'l', 'a', ' ', 'm', 'a', ' ' };
            char[] tekst2 = { 'k', 'o', 't', 'a'};
           
            Console.WriteLine(Concat(tekst1, tekst2));
            Console.ReadKey();
        }
    }
}
