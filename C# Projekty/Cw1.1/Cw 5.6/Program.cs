using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw_5._6
{
    internal class Program
    { 
        static int Ma(int[] t, out int n, out int l)
        {
            int m = 7; n = -1; l = -1;
            for (int i = 0; i < t.Length; i++)
                for (int j = i + 1; j < t.Length; j++)
                {
                    if (t[i] + t[j] == m)
                    {
                        return 1;
                    }
                   


                }
            return 0;


        }
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] t = new int[5];
            for (int i = 0; i < t.Length; i++)
                t[i] = rnd.Next(7);
                int n, l;
            foreach (int i in t)
                Console.WriteLine(i);
            int wynik = Ma(t, out n, out l);
            if ( wynik == 1)
                Console.WriteLine("t[i] + t[j] == m istnieje");
            else
                Console.WriteLine("t[i] + t[j] == m nie istnieje");
            Console.ReadKey();


        }
    }
}
