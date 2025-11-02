using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw_6._3
{
    internal class Program
    {
        static int Suma(int z)
        {
            if (z == 0) return 0;
           else return z = z + Suma(z - 1);

        }
        static void Main(string[] args)
        {
            Console.WriteLine("podaj l calkowita nieujemma");
            int z = int.Parse(Console.ReadLine());
           Console.WriteLine( Suma (z));
            Console.ReadKey();
        }
    }
}
