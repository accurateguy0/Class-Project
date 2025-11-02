using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj l naturalna ");
            int n = Convert.ToInt32(Console.ReadLine());
            int k = 1;
            int suma = 0;
            while (n >=k)
            {
                suma = suma + k;
                k++;
            }
            Console.WriteLine(suma);
            Console.ReadKey();
        }
    }
}
