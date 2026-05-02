using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    enum DniTygodnia { Poniedzialek = 1, Wtorek, Sroda, Czwartek, Piatek, Sobota, Niedziela }
    internal class Program
    {
        
    
    
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj numer rownowartosciowa tygodnia");
                DniTygodnia dzienKonsultacji = DniTygodnia.Sroda;
            int liczba = int.Parse(Console.ReadLine());
            int l = liczba;
            Console.WriteLine((DniTygodnia)liczba);
            if (liczba > 3)
                l = 10 - l;
            else l = 3 - l;
                
            if (dzienKonsultacji == (DniTygodnia)liczba)
            {
                Console.WriteLine("Dzisiaj jest dzien konsultacji");
            }
            else
            {
                Console.WriteLine("Dzien konsultacji za {0} dni", l);
            }
            Console.ReadKey();
        }
    }
}
