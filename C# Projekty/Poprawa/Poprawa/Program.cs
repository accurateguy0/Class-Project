  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poprawa
{
    internal class Program
    {
        static int Metoda(int n)
        {
            if (n <= 1) return n;
            else return n + Metoda(n - 1);

        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Metoda(n));
            Console.ReadKey(); 
        }
    }
}
