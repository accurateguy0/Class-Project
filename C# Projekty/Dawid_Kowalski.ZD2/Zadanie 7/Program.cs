using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Zadanie_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" program pobierający wartość początkową kwoty");
            int k= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("az oprocentowanie roczne(w procentach) obligacji o kapitalizacji rocznej, a następnie obliczający kwotę otrzymaną na zakończenie po 10 latach");
            int o=Convert.ToInt32(Console.ReadLine());
            double kapital = 0;
            double y = (100 * 12);
            double x = o / y;
            
            double z = Math.Pow(1 +x, 12 * 10);
            kapital = k * z;
           
            Console.WriteLine(kapital);
            Console.ReadKey();
        }
    }
}
