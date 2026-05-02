using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw_7._3
{
    internal class Program
    {
        static void Binarna(int n)
        {
            Stack<int> b = new Stack<int>();
            while (n > 0)
            {
                b.Push(n % 2);
                n /= 2;
            }
               while (b.Count > 0)
                  Console.Write(b.Pop());
        }
        static void Main(string[] args)
        {
            Console.WriteLine("podaj n");
            int n = int.Parse(Console.ReadLine());
            Binarna(n);
            Console.ReadKey();
        }
    }
}
