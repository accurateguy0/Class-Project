using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("podaj 1 l calkowita");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("podaj 2 l calkowita");
            int b = int.Parse(Console.ReadLine());
            if(a%b == 0)
                Console.WriteLine("1 liczba jest dzielnikiem drugiej");
            else
                Console.WriteLine("1 liczba nie jest dzielnikiem drugiej");
            Console.ReadKey();
        }
        
    }
}
