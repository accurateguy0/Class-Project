using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3_A
{
    internal class Program
    {
        static void Metoda3(char[]tab)
        {
            
            int k = 0;
            char[] Wielka = new char[tab.Length];
           for(int i  = 0; i < tab.Length; i++) 
            {
                int m = tab[i];
                if (m > 96)
                {
                   
                    k = tab[i] - 32;
                    Wielka[i] = (char)k;
                }
                if(m < 90)
                Wielka[i] = tab[i];
               
            }
           foreach (char c in Wielka) 
                Console.Write(c);
        }
        static void Main(string[] args)
        {
            char[] tab1 = { 'A', 'l', 'a' };
                Metoda3(tab1);
            
           
            Console.ReadKey();
        }
    }
}
