using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("System ogrzewania. Podaj temperature");
            int t = Convert.ToInt32(Console.ReadLine());
            if (t < 20)
            {
                Console.WriteLine("włacz ogrzewanie ");
            }
            else if (t > 30)
            {
                Console.WriteLine("włącz klimatyzację ");
            }
            else
            {
                Console.WriteLine("temperatura OK ");
            }
            Console.ReadKey();
        }
    }
}
