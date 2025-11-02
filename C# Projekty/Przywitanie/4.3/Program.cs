using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj tablice n elementowa");
            int n = int.Parse(Console.ReadLine());
            int[] tab = new int[n];
            Console.WriteLine("podaj n liczb calkowitych");
            for (int i = 0; i < n; i++)
                tab[i] = int.Parse(Console.ReadLine());

            int max = tab[0];
            for (int i = 0; i < tab.Length; i++)
                if(tab[i] > max)
                    max = tab[i];

            int min  = tab[0];
            for (int i = 0; i < tab.Length; i++)
                if (tab[i] < min)
                    min = tab[i];
      
            int suma = 0;
            for (int i = 0; i < tab.Length; i++)
                suma += tab[i];
            double srednia = (double)suma/(double)tab.Length;

            int dodat = 0;
            for (int i = 0;i < tab.Length; i++)
                if(tab[i] > 0)
                    dodat += 1;
            Console.WriteLine("najwieksza to: {0}", max);
            Console.WriteLine("najmniejsza to:{0}", min);
            Console.WriteLine("srednia to: {0}",srednia);
            Console.WriteLine("ilosc liczby dodatniej na tablicy to: {0}", dodat);
            Console.ReadKey();
        }
    }
}
