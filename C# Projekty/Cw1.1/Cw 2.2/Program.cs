using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw_2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            int c = 3;
            if (c - b == b - a)
                Console.WriteLine("jest arytmetyczny");
            else if (a - b == b - c)
                Console.WriteLine("jest arytmetyczny");
            else Console.WriteLine(" nie jest arytmetyczny");

        }
    }
}
