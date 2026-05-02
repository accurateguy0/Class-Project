using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw_3._4
{
    internal class Program
    {
        static void Prostokat(int[,] tab)
        {
            int x1 = tab[0,0];
            int y1 = tab[0,1];
            int x2 = tab[0,2];
            int y2 = tab[0,3];
            int x3 = tab[1,0];
            int y3 = tab[1,1];
            int x4 = tab[1,2];
            int y4 = tab[1,3];
            if (x3 <= x1 && x1 <= x4 && y3 <= y1 && y1 <= y4)
                Console.WriteLine("maja punkty wspolne");
            else if (x3 <= x2 && x2 <= x4 && y3 <= y2 && y2 <= y4)
                Console.WriteLine("maja punkty wspolne");
            else Console.WriteLine("nie maja punkty wspolne");
        }

        static void Main(string[] args)
        {
            int[,] tab = new int[2, 4] { { 1, 2, 3, 4 }, { 2, 3, 4, 5 } };
            Prostokat(tab);
            Console.ReadKey();
        }
    }
}
