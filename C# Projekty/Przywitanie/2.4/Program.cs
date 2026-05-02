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
            Console.WriteLine("Kalkulator");
            Console.WriteLine("podaj liczbe a");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("podaj liczbe b");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("podaj znaki +,-,/,*");
            double wynik;
            string znak = Console.ReadLine();
            switch(znak)
            {
                case "+":
                     wynik = a + b;
                    Console.WriteLine(a + " + " + b + " = " + wynik);
                    break;
                case "-":
                    wynik = a - b;
                    Console.WriteLine(a + " - " + b + " = " + wynik);
                    break;
                case "/":
                    wynik = a / b;
                    Console.WriteLine(a + " / " + b + " = " + wynik);
                    break;
                case "*":
                    wynik = a * b;
                    Console.WriteLine(a + " * " + b + " = " + wynik);
                    break;

            }
            Console.ReadKey();
            
                
        }
    }
}
