using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw_3._2
{
    internal class Program
    {
        static int Najwieksza(int a, int b, int c)
        {
            int naj = 0;
            if (a > b && a > c)
                Console.WriteLine("a jest najwieksza");
            else
                naj = (b < c && b < a) ? naj++ : naj--;
            return naj;
        }
        static void Main(string[] args)
        {
            int a = 1; int b = 2; int c = 3;
            if(Najwieksza(a, b, c) == 1)
            Console.WriteLine("b jest najwieksza");
            else
            Console.WriteLine("c jest najwieksza");
            Console.ReadKey();
        }
    }
}
