using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._7
{
    internal class Program
    {
        static int Dodaj(int n, int x)
        {
            if (n > 1) return (x + n + Dodaj(n - 1, x));
            else return x + n; 
        }
        static void Main(string[] args)
        {
            Console.WriteLine("podaj n");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("podaj x");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine(Dodaj(n, x));
            Console.ReadKey();
        }
    }
}
