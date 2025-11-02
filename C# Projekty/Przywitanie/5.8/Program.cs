using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._8
{
    internal class Program
    {
        static int suma(string x) 
        {
            int suma = 0;
            for (int i = 0; i < x.Length; i++)
            {
                int a = int.Parse(x.Substring(i, 1));
                suma += a;
            }
            return suma;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("wczytaj x naturalna");
            string x = Console.ReadLine();
            Console.WriteLine(suma(x));
            Console.ReadKey();
        }
    }
}
