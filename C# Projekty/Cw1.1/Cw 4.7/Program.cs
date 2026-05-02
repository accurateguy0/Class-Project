using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw_4._7
{
    internal class Program
    {
        static void IloczynSkalarny( double[]L, params double[] K)
        {
            double[] tab = new double[L.Length];
            for (int i = 0; i < L.Length; i++)
                tab[i] = K[i] * L[i];
            foreach (double l in tab)
                Console.Write(l + "   ");
        }
        static void Main(string[] args)
        {
            Random rnd = new Random();
            double[] L = new double[4];
            double[] K = new double[4];
            for (int i = 0; i < L.Length; i++) 
                L[i] = rnd.NextDouble();
            for (int i = 0; i < L.Length; i++)
                K[i] = rnd.NextDouble();
            if (L.Length == K.Length)
                IloczynSkalarny(L, K);
            Console.ReadKey();
        }
    }
}
