using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._6
{
    internal class Program
    {
        static string[] Element(int mnoznik, string[] tab)
        {

            for (int i = 0; i < tab.Length; i++)
                for (int j = 1; j < mnoznik; j++)
                    tab[i] = string.Concat(tab[i], tab[i]);


            return (tab);
        }

        static void Main(string[] args)
        {
            string[] tab1 = new string[3] { "ala", "dom", "kot" };
            Console.Write("tab1:");
            foreach (string i in tab1)
                Console.Write("{0}, ", i);
            Console.WriteLine();

            int mnoznik = 2;
            string[] tab2 = Element(mnoznik, tab1);
            Console.Write("tab2: ");
            for (int i = 0; i < tab2.Length; i++)
                Console.Write(tab2[i] + " ");
            Console.ReadKey();
        }
    }
}
