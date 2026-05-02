using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw_6._5
{
    internal class Program
    {
        static int Potega(int n)
        {
            if (n == 0) return 0;
            else return Potega(n - 1) + n + n - 1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("podaj l calkowita dodatnia");
            int l = int.Parse(Console.ReadLine());
            Console.WriteLine(Potega(l));
            Console.ReadKey();
        }
    }
}
