using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._1
{
    public class Prostokat
    {
        private int dlugosc;
        private int szerokosc;
        private int powierzchnia
        {
            get { return dlugosc * szerokosc; }
        }
        private int obwod
        {
            get { return 2*(dlugosc + szerokosc); }
        }
        public void Prezentuj()
        {
            Console.WriteLine("Powierzchnia: {0} Obwod: {1}", powierzchnia, obwod);
        }
        public Prostokat(int dlug, int szer)
        {
            dlugosc = dlug;
            szerokosc = szer;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Prostokat p1 = new Prostokat(4, 5);
           p1.Prezentuj();
            Console.ReadKey();
        }
    }
}
