using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw._3._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string HEX;
            int ilosc = 3;
            int i = 0;
            bool ok = true;
            int l = 0;
            while(ilosc >= 0)
            {
                Console.WriteLine("podaj kolejna liczbe w systemie HEX");
                HEX = Console.ReadLine();
                HEX = HEX.ToLower();
                switch(HEX )
                {
                    case "0": i = 0; break;
                    case "1": i = 1; break;
                    case "2": i = 2; break;
                    case "3": i = 3; break;
                    case "4": i = 4; break;
                    case "5": i = 5; break;
                    case "6": i = 6; break;
                    case "7": i = 7; break;
                    case "8": i = 8; break;
                    case "9": i = 9; break;
                    case "a": i = 10; break;
                    case "b": i = 11; break;
                    case "c": i = 12; break;
                    case "d": i = 13; break;
                    case "e": i = 14; break;
                    case "f": i = 15; break;
                    default: ok = false;
                            Console.WriteLine("podano zly znak. Jeszcze raz"); break;
                }
                if (ok)
                {
                    l = (int)(l + i * Math.Pow(16, ilosc));
                    ilosc--;
                }
                else
                    ok = true;
            }
            Console.WriteLine(l);
            Console.ReadKey();
        }
    }
}
