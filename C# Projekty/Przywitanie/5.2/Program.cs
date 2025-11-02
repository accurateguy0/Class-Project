using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2
{
    internal class Program
    {
        static bool przedzial(int a, int b, int x)
        {
            bool result = (a < x && b > x) || (a > x && b < x);
                return result;
        }
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int a = rnd.Next(1,100);
            int b = rnd.Next(1, 100);
            int x = rnd.Next(1, 100);
            if(przedzial(a, b, x) == true)
                Console.WriteLine("x lezy w przedziale {0}-{1}",a, b);
            else Console.WriteLine("x nie lezy w przedziale {0}-{1}",a, b);
            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}
