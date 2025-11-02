using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _6._5
{
    public class Odcinek
    {
        public Punkt p1, p2;
        public Odcinek(Punkt p1, Punkt p2)
        {
            this.p1 = p1;
            this.p2 = p2;
        }

        public double odcinek()
        {
            return Math.Sqrt(Math.Pow(p2.Wx - p1.Wx, 2) + Math.Pow(p2.Wy - p1.Wy, 2));

        }
    }
        public class Punkt
        {
            public int Wx;
            public int Wy;
            public Punkt(int x, int y)
            {
                Wx = x;
                Wy = y;
            }
            public void Przesun()
            {
                Wx += 1;
                Wy += 3;
            }
            public void Wyswietl()
            {
                //Console.WriteLine(" wspolrzedna punktu to: {0},{1}", Wx, Wy);
               
            }
            public static bool CzyNaJednejProstej(Punkt p1, Punkt p2, Punkt p3)
            {
                return ((p2.Wy - p1.Wy) * (p3.Wx - p2.Wx) == (p3.Wy - p2.Wy) * (p2.Wx - p1.Wx));
            }
        }

        internal class Program
        {

            static void Main(string[] args)
            {
                Punkt[] punkt = { new Punkt(1, 2), new Punkt(2, 3), new Punkt(3, 4) };
                Punkt p1 = new Punkt(1, 2); 
                Punkt p2 = new Punkt(4, 6);
                //    punkt[0].Wyswietl();
                //a.Przesun();
                //Console.Write("po przesunieciu");
                //a.Wyswietl();
                if (Punkt.CzyNaJednejProstej(punkt[0], punkt[1], punkt[2]) == true)
                    Console.WriteLine("sa na jednej prostej");
                else
                    Console.WriteLine("nie sa na jednej prostej");
                Odcinek odcinek = new Odcinek(p1, p2);
                Console.WriteLine("odcinek ma dlugosc: {0}", odcinek.odcinek());
                Console.ReadKey();
            }
        }
    
}
