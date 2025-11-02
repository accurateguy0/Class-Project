using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj liczbę n ");
            int n = int.Parse(Console.ReadLine());
            int suma = 0;
            while (n > 0)
            {
                suma += n % 10;
                n = n / 10;
            }
            Console.Write(suma);
            Console.ReadKey();
        }
    }
}
