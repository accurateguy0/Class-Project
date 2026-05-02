using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 3, b = 4, c = 5;
            if (a + b > c | a + c > b | b + c > a)
            {
                Console.WriteLine("mozna z tego trojkat zrobic");
            }
            else
                Console.WriteLine("nie da sie trojkata zrobic");
            Console.ReadKey();
            
            
        }
    }
}
