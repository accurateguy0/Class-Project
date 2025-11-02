using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_1_A
{
    internal class Program
    {
        static void Metoda1(int n)
        {
            int i = n;
            char[] znaki = { '*', '+', '#' };
            do
            {
                int j = 0;
                do
                {
                    Console.Write( znaki[j % 3]);
                    j++;
                } while (j < i);
                Console.WriteLine();
                i--;
            }while(i > 0);
        }
        static void Main(string[] args)
        {
            Metoda1(6);
             Console.ReadKey(); 
        }
    }
}
