using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Cw_5._8
{
    internal class Program
    {
        static void Zamiana(double [] a, int i, int j)
        {
            if (i >= a.Length || j >= a.Length)
                throw new Exception("jedno z indeksow jest poza zakresem");
            double zmn = a[i];
            a[i] = a[j];
            a[j] = zmn;
        }
        static void Main(string[] args)
        {
            double[] a = { -1.2, 2.1, -3.5, 2.7, 0.8 };
            foreach (int i in a) 
                Console.Write(i + " ");
            Console.WriteLine();
            Zamiana(a, 0, 3);
            foreach (int i in a)
                Console.Write(i + " ");
            Console.ReadKey();

        }
    }
}
