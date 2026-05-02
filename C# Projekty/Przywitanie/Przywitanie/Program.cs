using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przywitanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool kino;
            Console.WriteLine("wiek");
            double wiek = double.Parse(Console.ReadLine());
            Console.WriteLine("PLN");
            double PLN = double.Parse(Console.ReadLine());
            kino = (wiek >= 18 && PLN >= 20);
            Console.WriteLine(kino);
            Console.ReadKey();
        }
    }
}
