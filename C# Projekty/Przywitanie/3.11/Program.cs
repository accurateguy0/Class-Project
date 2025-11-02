using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ile kolejnych liczb całkowitych należy dodać do siebie, aby suma przekroczyła wartość 100.");
            int l = 0;
            int n = 0;
            while(l<100)
            {
                n++;
                l += n;
                
            }
            Console.WriteLine(n);
            Console.ReadKey();
        }
    }
}
