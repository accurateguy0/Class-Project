using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj pole koła (d):");
            double d = Convert.ToDouble(Console.ReadLine());

            double radius = Math.Sqrt(d / Math.PI);

            Console.WriteLine("Promień koła wynosi: " + radius);
            Console.ReadLine();
        }
    }
}
