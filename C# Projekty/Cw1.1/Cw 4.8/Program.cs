using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw_4._8
{
    internal class Program
    {
        static bool Palidrom( char[] tab, char[] tab1)
        {
            bool b = true;
            for (int i = 0; i < tab.Length; i++) 
            if (tab[i]!= tab1[i])
                {
                    Console.Write("nie jest polidromem");
                    break;
            
                }
               else
                    b = false;
            return b;
        }
        static void Main(string[] args)
        {
            char[] tab = { 'a', 'l', 'a' };
            char[] tab1 = new char[tab.Length] ;
            Array.Copy(tab, 0, tab1, 0, tab.Length);
            Array.Reverse(tab1);
            if (Palidrom(tab, tab1) == false)
                Console.WriteLine("jest polidromem");
            Console.ReadKey ();
        }
    }
}
