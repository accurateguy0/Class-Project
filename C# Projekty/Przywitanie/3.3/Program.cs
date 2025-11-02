using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("podaj liczbe");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("podaj 2 liczbe");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("podaj 3 liczbe");
            int c = int.Parse(Console.ReadLine());
            if (a > b && a > c)
                Console.WriteLine("a najwieksza");
            else if (b > a && b > c)
                Console.WriteLine("b najwieksza");
            else
                Console.WriteLine("c najwieksza");
            Console.ReadKey();
        }
       
    }
}
