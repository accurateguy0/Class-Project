using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._10
{
    internal class Program
    {
        static int Oblicz(int n)
        {
            if (n <= 1) return (1);
            else return (n + Oblicz(n - 1));
        }
            static void Main(string[] args)
        {
            Console.WriteLine("podaj n");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Oblicz(n));
            Console.ReadKey();  

        }
    }
}
