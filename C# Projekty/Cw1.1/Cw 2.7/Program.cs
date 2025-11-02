using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw_2._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tydzien = 1;
            int n = int.Parse(Console.ReadLine());
            int zar = 1;
            int uzd = 1;
            int luzd = 1;
            while(n>tydzien)
            {
                if (tydzien <= 1)
                {
                    zar = zar * 2 + zar;
                    
                }
                else 
                {
                    uzd = zar - uzd;
                    zar = zar * 3 - luzd;
                    luzd = uzd;
                }
               tydzien++;
               
            }
            Console.WriteLine("{0} osob zarazonych w {1} tygodniu", zar, tydzien);
            Console.ReadKey();
        }
    }
}
