using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2_B
{
    internal class Program
    {
        static double Metoda2(int n)
        {
            int i = 1;
            int j = 0;
            int m = n;
            double o = 0;
            while (n > 9)
            {
                n = n / 10; 
                i++;
            }
            
            while (i > 0)
            {
               
                double l = Math.Pow(6, j) * m % 10; ;
               
                o = o + l;
                m = m / 10;
                i--;
                j++;
            }
            return o;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
           Console.Write(Metoda2(n));
            Console.ReadKey();
        }
    }
}
