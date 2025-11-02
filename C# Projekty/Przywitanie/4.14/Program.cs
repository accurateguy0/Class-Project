using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = 0;
            string[] srodek = { "KOMG-2002", "BH-2010", "KOMP-2000", "XBOX-2016", "BOXX-1999" };
            for (int i = 0; i < srodek.Length; i++) 
            {
                    string frag1 = srodek[i].Substring(start, srodek[i].IndexOf("-"));
                    start = srodek[i].IndexOf("-") +1;
                    string frag2 = srodek[i].Substring(start, 4);
                    int frags = int.Parse(frag2);
                    int lat = 2024 - frags;
              
                  Console.WriteLine("Dla srodka trwalego {0} uplynelo {1} lat", frag1, lat);
                start = 0;
                   

            }
            Console.ReadKey();
        }
          
    }
}
