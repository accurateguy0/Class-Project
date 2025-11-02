using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("podaj rok");
            int r = int.Parse (Console.ReadLine());
           
            if (r % 400 == 0)
                Console.WriteLine("rok przystepny");
            else if (r % 100 == 0)
                Console.WriteLine("zwykly rok ");
            else if (r % 4 == 0)
                Console.WriteLine("rok przystepny ");
            else
                Console.WriteLine("zwykly rok");
            

            Console.ReadKey();
        }
    }
}
