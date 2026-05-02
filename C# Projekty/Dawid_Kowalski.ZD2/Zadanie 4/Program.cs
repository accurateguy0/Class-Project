using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj l calkowita dodatnia");
            int n = Convert.ToInt32(Console.ReadLine());
            int k = 3;
            int suma = 0;
           
            while (n > k)
            {

                if (k % 5 != 0)
                    suma = suma + k;
                k = k + 2;
                
            }
            Console.WriteLine(suma);
            Console.ReadKey();
        }
    }
}
