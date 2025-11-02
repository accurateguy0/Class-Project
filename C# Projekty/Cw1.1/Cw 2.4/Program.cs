using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw_2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pierwsza = 9;
            int dzielniki = 0;
            for (int i = 1; i < pierwsza; i++) 
            if(pierwsza % i== 0)
                    dzielniki++;
            if (dzielniki < 2)
                Console.WriteLine("jest liczba pierwsza");
            else Console.WriteLine("nie jest liczba pierwsza");
            Console.ReadKey();
        }
    }
}
