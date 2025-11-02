using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._4_2._9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int x = 1, y = 3, z = 4;
            bool wynik = (x == 1 | y++ > 2 | ++z > 0);
            Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
            Console.ReadKey();
        }
    }
}
