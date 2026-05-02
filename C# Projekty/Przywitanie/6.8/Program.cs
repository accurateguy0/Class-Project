using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._8
{
    public class Prostopadloscian
    {
        public int dlugosc;
        public int szerokosc;
        public int wysokosc;
        public Prostopadloscian(int dlu, int sze, int wys)
        {
            dlugosc = dlu;
            szerokosc = sze;
            wysokosc = wys;
        }
        public int Objetosc
        {
            get { return dlugosc * szerokosc * wysokosc; } 
        }
            public void Pokaz()
        {
            Console.WriteLine("objetosc prostopadloscianu to: {0}", Objetosc);

        }
        public int Porownaj(Prostopadloscian InnyProstopadloscian)
        {
            int objetosc1 = this.Objetosc;
            int objetosc2 = InnyProstopadloscian.Objetosc;
            if (objetosc1 == objetosc2)
                return 0;
            else if (objetosc1 < objetosc2)
                return 1;
            else return -1;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int wysokosc = 1;
            int szerokosc = 1;
            int dlugosc = 1;
            Prostopadloscian p1 = new Prostopadloscian(wysokosc,  szerokosc, wysokosc);
            Prostopadloscian p2 = new Prostopadloscian(3, 4, 6);
            p1.Pokaz();
            p2.Pokaz();
           int porownaj = p1.Porownaj(p2);
            if (porownaj == 0)
                Console.WriteLine("obie sa rowne w objetosci");
            if (porownaj == 1)
                Console.WriteLine("druga jest wieksza");
            else
                Console.WriteLine("pierwsza jest wieksza");

            Console.ReadKey();
        }
    }
}
