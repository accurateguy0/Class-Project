using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int znakow = 0;
            int wierszy = 0;
            string tekst = "W parę godzin później, gdy noc zbierała się do odejścia,\n" +
 "Puchatek obudził się nagle z uczuciem dziwnego przygnębienia.\n" +
 "To uczucie dziwnego przygnębienia miewał już nieraz i wiedział,\n" +
 "co ono oznacza. Był głodny. Więc poszedł do spiżarni,\n" +
 "wgramolił się na krzesełko, sięgnął na górną półkę, ale nic nie znalazł.\n";
            for (int i = 0; i < tekst.Length; i++)
            {
                znakow++;
                if (tekst[i] == '\n')
                {
                    wierszy++;
                    Console.WriteLine("liczba znakow w {0} wierszu: {1}", wierszy, znakow);
                    znakow = 0;
                }
                    
            }
               Console.ReadKey();
        }
    }
}
