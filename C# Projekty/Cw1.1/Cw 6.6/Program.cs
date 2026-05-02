using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw_6._6
{
    internal class Program
    {
        static int WyszBin(int[] t, int n, int pocz, int kon)
        {
            if (pocz == kon)
            {
                if(t[pocz] == n)
             return pocz;
                else return -1;
            }
            int srodek = (pocz + kon) / 2;
            if (n <= srodek)
                return WyszBin(t, n, pocz, srodek);
            else
                return WyszBin(t, n, srodek + 1, kon);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("podaj rozmiar tablicy");
            int n = int.Parse(Console.ReadLine());
            int [] t = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                t[i] = rnd.Next(50);
            }
            Array.Sort(t);
            for (int i = 0;i < n; i++)
                Console.Write(t[i] + " ");
            Console.WriteLine("===== Wysz Bin ======");
            Console.WriteLine(WyszBin(t, 45, 0, t.Length - 1));
            Console.ReadKey();
        }
    }
}
