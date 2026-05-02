using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw_5._2
{
    internal class Program
    {
        static double[] Nieujemna(double[] L)
        {
            double[] tab = new double[L.Length];
            for (int i = 0; i <L.Length;i++)
                if (L[i] > 0)
                  tab[i] = L[i];
            return tab;
        }
        static void Main(string[] args)
        {
            Random rnd = new Random();
            double[] L = new double[4];

            for (int i = 0; i < L.Length; i++)
                L[i] = rnd.NextDouble();
            foreach (double i in Nieujemna(L))
                Console.WriteLine(i);
            Console.ReadKey();
        }
    }
}
