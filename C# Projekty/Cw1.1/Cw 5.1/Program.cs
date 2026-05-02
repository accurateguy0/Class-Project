using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw_5._1
{
    internal class Program
    {
        static double [] Zamiana(double[] L)
        {
            for (int i = 0; i < L.Length; i++)
                L[i] -= 2 * L[i];
            return L;
        }
        static void Main(string[] args)
        {
            Random rnd = new Random();
            double[] L = new double[4];
           
            for (int i = 0; i < L.Length; i++)
                L[i] = rnd.NextDouble();
           foreach (double i in L)
                Console.WriteLine(i);
            foreach(double i in Zamiana(L))
                Console.WriteLine(i);
            Console.ReadKey();
        }
    }
}
