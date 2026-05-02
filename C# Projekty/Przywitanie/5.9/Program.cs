using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace _5._9
{
    internal class Program
    {
        //static int Fibo(int n)
        //{
        //    if (n <= 1) return n;
        //    else return Fibo(n - 1) + Fibo(n - 2);
        //}
        static int Fibo(int n )
        {
            int a = 0;
            int b = 1;
            for (int i = 1; i < n; i++)
            {
                b += a;
                a = b - a;
            }
                
            if(n == 0) return (b);
            else return ( b);
        }
       
        static void Main(string[] args)
        {
            Console.WriteLine("Ciag Fibonacciego. podaj n");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Fibo(n));
            Console.ReadKey();
        }
    }
}
