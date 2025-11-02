using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            Random random = new Random();
            Console.WriteLine("dwuwymiarowa z 5 elementami.");
            int[,] tab = new int[5, 5];
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    tab[i, j] = random.Next(1, 100); random.Next(1, 100);
                    Console.Write("{0,3}", tab[i,j]);
                }
               
                    Console.WriteLine();

            }
            for (int n = 0; n < tab.GetLength(1); n++)
                suma += tab[n, n];
            Console.WriteLine("suma przekatnej to: {0}",suma);

            Console.ReadKey();
        }
    }
}
