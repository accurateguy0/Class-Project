using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("podaj [dzien, miesiac, rok]");
            string g = Console.ReadLine();
            int f = int.Parse(g.Substring(3, 2));
           switch(f)
            {
                case 01:
                    Console.WriteLine("styczen");
                    break;
                case 02:
                    Console.WriteLine("luty");
                    break;
                case 03:
                    Console.WriteLine("marzec");
                    break;
                case 04:
                    Console.WriteLine("kwiecien");
                    break;
                case 05:
                    Console.WriteLine("maj");
                    break;
                case 06:
                    Console.WriteLine("czerwiec");
                    break;
                default:
                    Console.WriteLine("nie ma takiego miesiaca");
                    break ;
            }
            Console.ReadKey();
        }
    }
}
