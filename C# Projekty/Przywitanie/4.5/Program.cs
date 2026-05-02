using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _4._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("podaj n elementowa tablice");
            int n = int.Parse(Console.ReadLine());
            int[] tab1 = new int [n];
            int[] tab2 = new int [n];
            for (int i = 0; i < n; i++)
                tab1[i] = i+1;

            Array.Copy(tab1, 0, tab2, 1, (tab1.Length - 1));
            tab2[0] = tab1 [n-1];
            Console.WriteLine("tab1:");
            foreach (int f in tab1)
                Console.Write("{0}, ",f);
            Console.WriteLine();
            Console.WriteLine("tab2:");
            foreach (int i in tab2)
                Console.Write("{0}, ", i);
            Console.ReadKey();

        }
    }
}
