using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw_1._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("podaj pole kola");
            double d = double.Parse(Console.ReadLine());
            double r = Math.Sqrt(d / Math.PI);
            Console.WriteLine("promien kola to " + r);
            Console.ReadKey();
        }
    }
}
