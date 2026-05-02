using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = 0;
            while (n > 0)
            {
                
                    if (n % 3 == 0 & n % 5 != 0)
                        l += n;


                n--;
            }
            Console.WriteLine(l);
            Console.ReadKey();
        }
    }
}
