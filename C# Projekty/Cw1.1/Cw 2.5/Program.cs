using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw_2._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            int n = 4;
            int i = 0;
            while (i < n)
            {
                i++;
                if (i % 2 == 0)
                    if (i % 5 != 0)
                    suma += i;
            }
            Console.WriteLine(suma);
            Console.ReadKey();
        }
    }
}
