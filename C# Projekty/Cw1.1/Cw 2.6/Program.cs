using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw_2._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int liczba = 12345;
            Console.WriteLine("liczba od prawej do lewej");
            while (liczba > 0)
            {
                Console.Write(liczba % 10 + " ");
                liczba /= 10;   
            }
            Console.ReadKey();
        }
    }
}
