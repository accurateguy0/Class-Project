using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw_3._3
{
    internal class Program
    {
        static void PunktyWspolne(int x1, int x2, int x3, int x4)
        {
            if ( x3 <= x1 && x1 <= x4)
                Console.WriteLine("maja punkty wspolne");
            else if ( x3 <= x2 && x2 <= x4)
                Console.WriteLine("maja punkty wspolne");
            else Console.WriteLine("nie maja punkty wspolne");
        }
        static void Main(string[] args)
        {
            int x4 = 4;
            int x3 = 3;
            int x2 = 2;
            int x1 = 2;
            PunktyWspolne(x1, x2, x3, x4);
            Console.ReadKey();
        }
    }
}
