using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3_Zad
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Podaj wage w kg");
            int masa = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wzrost w m");
            double wzrost = double.Parse(Console.ReadLine());
          double BMI = masa/Math.Pow(wzrost, 2);
            Console.WriteLine(BMI);
            Console.ReadKey();
        }
    }
}
