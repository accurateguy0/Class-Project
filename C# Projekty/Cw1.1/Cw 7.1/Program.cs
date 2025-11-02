using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw_7._1
{
    class Prostokat
    {
        public int wysokosc, szerokosc;
        public int x, y;
    }
    internal class Program
    {
        static Prostokat Utworz(int x, int y, int wysokosc, int szerokosc)
        {
            Prostokat p = new Prostokat();
            p.x = x;
            p.y = y;
            p.wysokosc = wysokosc;
            p.szerokosc = szerokosc;
            return p;

        }

        static int Pole(Prostokat p)
        {
            return p.wysokosc*p.szerokosc;
        }
        static int Obwod(Prostokat p)
        {
            return 2*(p.wysokosc + p.szerokosc);
        }
        static void Przesuwanie (Prostokat p, int px, int py)
        {
            p.x += px;
            p.y += py;
        }
        static void Skalowanie (Prostokat p, int s)
        {
            p.wysokosc *= s;
            p.szerokosc *= s;
        }
        static Prostokat Kopia(Prostokat p)
        {
            Prostokat pKopia = new Prostokat();
            pKopia.x = p.x;
            pKopia.y = p.y;
            pKopia.wysokosc = p.wysokosc;
            pKopia.szerokosc = p.szerokosc;
            return pKopia;
        }
        static void Wyswietl(Prostokat p)
        {
            Console.WriteLine("prostokat zaczepiony w ({0} ; {1}) szerokośc = {2}; wysokość={3}", p.x, p.y, p.szerokosc, p.wysokosc);
        }
        static void Main(string[] args)
        {
            Prostokat a = Utworz(0, 2, 4, 5 );
            Wyswietl (a);
            Przesuwanie(a, 2, 3);
            Skalowanie(a, 2);
            Console.WriteLine("Pole: " + Pole(a));
            Console.WriteLine("Obwod: " + Obwod(a));

            Prostokat b = Utworz(2, 4, 3, 5);
           Wyswietl(b);
            Przesuwanie(b, 2, 3);
            Skalowanie(b, 2);
            Console.WriteLine("Pole: " + Pole(b));
            Console.WriteLine("Obwod: " + Obwod(b));
            Prostokat c = Kopia(a);
            Wyswietl(c);
            Przesuwanie(c, 2, 3);
            Skalowanie(c, 2);
            Console.WriteLine("Pole: " + Pole(c));
            Console.WriteLine("Obwod: " + Obwod(c));
            Console.ReadKey();
        }
    }
}
