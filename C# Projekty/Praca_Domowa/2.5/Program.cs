using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj liczbę n (n < 9): ");
            int n = int.Parse(Console.ReadLine());
            int suma = 0;
            int i = 1;
            int il = 0;
            int k = 1;
            while (n >= i)
            {
                for (int j = 0; j < k; j++)
                    il = il * 10 + i ;
                    
                suma += il;
                il = 0;
                if (i % 2 == 0)
                    k++;
                i++;
            }
            Console.WriteLine("Suma pierwszych {0} składników szeregu wynosi: {1}",n, suma);
            Console.ReadKey();
        }
    }
}
