using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Zadanie_2
{
    internal class Program
    {
        static void Metoda2(int n)
        {
            int i = 0;
            int m = n;
            do
            {
                n /= 10;
                i++;
            }while (1 < n);
            Console.WriteLine(i);        
            do
            {
                Math.Pow(m, i);
                m /= 10;
                i--;
            }while (m > 0);
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Metoda2(n);
            Console.ReadKey();
        }
    }
}
