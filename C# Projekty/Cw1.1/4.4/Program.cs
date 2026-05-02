using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._4
{
    internal class Program
    {
        static void Najw(params int[] tab)
        {
            int n = tab[0];
            for (int i = tab.Length-1; i > 0; i--)
            {
                if (tab[i] > n)
                n = tab[i];
            }
            Console.WriteLine("najwieksza l w tablicy:" + n);
        }
        static void Main(string[] args)
        {
            int [] tab = new int []{ 1, 7, 3 };
            Najw(tab);
            Console.ReadKey();
        }
    }
}
