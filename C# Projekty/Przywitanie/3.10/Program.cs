using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("podaj n sinie");
            int n = int.Parse(Console.ReadLine());
            int k = 1;
            while(n > 0)
            {
                
                k *= n;
                n -= 1;
            }
            Console.WriteLine(k);
            Console.ReadKey();
        }
    }
}
