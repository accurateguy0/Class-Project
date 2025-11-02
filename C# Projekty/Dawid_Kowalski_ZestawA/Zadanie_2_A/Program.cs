using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2_A
{
    internal class Program
    {
        static double Metoda2(int n)
        {
            int i = 1;
            int m = n;
            do
            {
                n = n % 10;
                i++;
            } while (n > 9);
            Console.WriteLine(i);
                double k;
            double l = 0;
            int j = 0;
           do
            {
                k = Math.Pow(8, j) * m % 10;
                m /= 10;
                l = l + k;
                j++;
                i--;
            } while (i > 0) ;
                return l;

        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Metoda2(n));
            Console.ReadKey();
        }
    }
}
