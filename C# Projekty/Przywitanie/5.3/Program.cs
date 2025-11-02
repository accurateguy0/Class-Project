using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3
{
    internal class Program
    {
        static void Przesun( ref double x, ref double y)
        {
            double wekx = x + 3;
            double weky =  y + 2;
            Console.WriteLine("{0}, {1}", wekx, weky);
            
        }
        static void Main(string[] args)
        {
            
            Console.WriteLine("Podaj wspolrzedne A, x i y");
            double Ax = double.Parse(Console.ReadLine());
            double Ay = double.Parse(Console.ReadLine());
            Console.WriteLine("przesunieto o wek [3, 2].");
            Przesun (ref Ax, ref Ay);
            Console.ReadKey();
        }
    }
}
