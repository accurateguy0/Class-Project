using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("podaj tekst");
            string tekst = Console.ReadLine();
            int litery = 0;
            for (int i = 0; i < tekst.Length; i++)
                if (tekst[i] != ' ')
                litery++;
            Console.WriteLine(litery);
            Console.ReadKey();
        }
    }
}
