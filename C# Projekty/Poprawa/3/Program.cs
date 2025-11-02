using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    internal class Program
    {
        static void Metoda(int[] tab)
        {
            int i = 0;

            do
            {
                int j = 0;
                do
                {
                    int tmp = tab[j];
                    tab[j] = (tab[j + 1] > tab[j]) ? tab[j + 1] : tab[j];
                    tab[j + 1] = (tab[j + 1] == tab[j]) ? tmp : tab[j + 1];
                    j++;
                } while (j < tab.Length - i - 1);
                i++;
            } while (i < tab.Length - 1);

        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] tab = new int[n];
            Random random = new Random();
            int i = 0;
            do
            {
                tab[i] = random.Next(-15, 15);
                i++;
            } while (i < tab.Length);
            foreach (int j in tab)
            {
                Console.Write(j + " ");
            }
                Metoda(tab);
            Console.WriteLine();
                foreach (int k in tab)
                {
                    Console.Write(k + " ");
                }
                Console.ReadKey();
            
        }
    }
}
