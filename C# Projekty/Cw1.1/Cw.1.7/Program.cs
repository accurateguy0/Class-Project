using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw._1._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("podaj l calkowita");
            double liczba = double.Parse(Console.ReadLine());
            if (liczba % 3 == 0)
                Console.WriteLine("jest podzielna przez 3");
            else
                Console.WriteLine("nie jest podzielna przez 3");
            Console.ReadKey();
        }
    }
}
