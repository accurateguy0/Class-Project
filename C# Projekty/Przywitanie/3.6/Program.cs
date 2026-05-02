using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("podaj wage w kg");
            double waga = double.Parse(Console.ReadLine());
            Console.WriteLine("podaj wzrost w m");
            double wzrost = double.Parse(Console.ReadLine());
            double BMI = waga / (Math.Pow(wzrost, 2));
            if (BMI < 18.5)
                Console.WriteLine("masz niedowage");
            if  (BMI <= 24.99)
                Console.WriteLine("wartosc prawidlowa");
            else
                Console.WriteLine("nadwaga");
            Console.WriteLine(BMI);
            Console.ReadKey();

        }
    }
}
