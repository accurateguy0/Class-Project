using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw_2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("podaj wzrost w cm");
            int wzrost = int.Parse(Console.ReadLine());
            if (wzrost > 200)
                Console.WriteLine("bardzo wysoki");
            else if (wzrost > 180)
                Console.WriteLine("wysoki");
            else if (wzrost > 150)
                Console.WriteLine("sredni");
            else 
                Console.WriteLine("niski");
            Console.ReadKey();

            
        }
    }
}
