using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("jakie jest twoje imie");
            string a = Console.ReadLine();
            Console.WriteLine("jakie jest twoje imie");
           a = a + Console.ReadLine();
            Console.WriteLine("{0} poznaje jezyk C#", a);
            Console.ReadKey();
        }
    }
}
