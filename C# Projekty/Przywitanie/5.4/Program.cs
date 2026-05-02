using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._4
{
    internal class Program
    {
        /*static void Elementy(int mnoznik, params int[] tab)
        {
            Console.Write("tab:");
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] *= mnoznik;
                Console.Write("{0}, ", tab[i]);
            }
        }*/
         static int[] Element (int mnoznik, int[] tab )
        {
           
            for ( int i = 0; i < 5; i++)
            {
                tab[i] *= mnoznik;
                
            }
            return (tab);
        }
        
        static void Main(string[] args)
        {
            int[] tab1 = new int[5] {1, 2, 3, 4, 5};
            Console.Write("tab1:");
            foreach ( int i in tab1 ) 
                Console.Write("{0}, ", i);
            Console.WriteLine();

            int mnoznik = 2;
            //Elementy(mnoznik, tab1);
            int[] tab2 = Element(mnoznik, tab1);
            Console.Write("tab2: ");
            for (int i = 0; i < 5; i++)
                Console.Write(tab2[i] + " ");

            
            Console.ReadKey();
        }
    }
}
