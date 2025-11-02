using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw_4._1
{
    internal class Program
    {
        static int Suma(int n)
        {
            int s = 0;
            while (n > 0)
            {
                if (n % 2 != 0)
                    s = s + n;
                n--;
            }
            //for(int i = 0; i <= n; i++)
            //{
            //    if (i % 2 != 0)
            //        s = s + i;
            //}
            return s;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("podaj n dodatnie");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Suma(n));
            Console.ReadKey();
        }
    }
}
