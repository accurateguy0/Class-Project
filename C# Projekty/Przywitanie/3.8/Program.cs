using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("podaj srednia ocen");
            double srednia = double.Parse(Console.ReadLine());
            if (srednia >= 2.00 && srednia < 3.99)
                Console.WriteLine("kwota stypendium: 0.00zl");
            else if (srednia < 4.79)
                Console.WriteLine("kwota stypendium: 350.00zl");
            else if (srednia <= 5.00)
                Console.WriteLine("kwota stypendium: 550.00zl");
            else
                Console.WriteLine("nie ma takiej sredniej");
            Console.ReadKey();
        }
    }
}

