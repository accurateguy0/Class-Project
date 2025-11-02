using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._10
{
    public struct KandydatNaStudia
    {
        public string nazwisko;
        public double mat;
        public double inf;
        public double jobce;
        public KandydatNaStudia(string Nazwisko, double punktyMatematyka, int punktyInformtyka, int punktyJezykObcy )
        {
            nazwisko = Nazwisko;
            mat = punktyMatematyka;
            inf = punktyInformtyka;
            jobce = punktyJezykObcy;
        }
        public void DaneUcznia()
        {
            Console.WriteLine("Nazwisko {0}, Suma Punktow: {1}", nazwisko, ObliczPunkty);
        }
        public double ObliczPunkty
        { 
            get { return mat * 0.6 + inf * 0.5 + jobce * 0.2; }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            KandydatNaStudia[] uczen = { new KandydatNaStudia("Kowalski", 60, 50, 98), 
                new KandydatNaStudia("Nowak", 40, 30, 100),
                new KandydatNaStudia("Szczesny", 50, 60, 100) };
            uczen[0].DaneUcznia();
            uczen[1].DaneUcznia();
            uczen[2].DaneUcznia();
            Console.ReadKey();
        }
    }
}
