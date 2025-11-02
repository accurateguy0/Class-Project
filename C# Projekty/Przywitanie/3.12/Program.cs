using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b = 0;
            do
            {
                Console.WriteLine("podaj l calkowita");
                 a = int.Parse(Console.ReadLine());
                 b += a;
            } while ( a != 0);
            Console.WriteLine(b);
            Console.ReadKey();
        }
    }
}
