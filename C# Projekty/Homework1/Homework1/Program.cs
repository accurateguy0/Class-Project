using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    internal class Program
    {
        static void Main(string[] args)
        {



            {
                // Prośba o podanie pierwszej liczby
                Console.WriteLine("Podaj pierwszą liczbę typu double:");
                double liczba1 = Convert.ToDouble(Console.ReadLine());

                // Prośba o podanie drugiej liczby
                Console.WriteLine("Podaj drugą liczbę typu double:");
                double liczba2 = Convert.ToDouble(Console.ReadLine());

                // Obliczanie średniej
                double srednia = (liczba1 + liczba2) / 2;

                // Wyświetlanie średniej
                Console.WriteLine("Średnia z podanych liczb to: " + srednia);

                // Czekanie na reakcję użytkownika
                Console.WriteLine("Naciśnij dowolny klawisz, aby zakończyć...");
                Console.ReadKey();
            }
        }
    }
}



