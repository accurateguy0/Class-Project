using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._9
{

    //public struct Prostokat
    //{
    //    private int dlugosc;
    //    private int szerokosc;
    //    private int powierzchnia
    //    {
    //        get { return dlugosc * szerokosc; }
    //    }
    //    private int obwod
    //    {
    //        get { return 2 * (dlugosc + szerokosc); }
    //    }
    //    public void Prezentuj()
    //    {
    //        Console.WriteLine("Powierzchnia: {0} Obwod: {1}", powierzchnia, obwod);
    //    }
    //    public Prostokat(int dlug, int szer)
    //    {
    //        dlugosc = dlug;
    //        szerokosc = szer;
    //    }
    //}
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Prostokat p1 = new Prostokat(4, 5);
    //        p1.Prezentuj();
    //        Console.ReadKey();
    //    }
    //}
    public struct Prostokat
    {
        private int dlugosc;
        private int szerokosc;
        private int powierzchnia
        {
            get { return dlugosc * szerokosc; }
        }
        private int obwod
        {
            get { return 2 * (dlugosc + szerokosc); }
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
        public static int Naj(Prostokat[] tab)
        {
            int naj = tab[0].powierzchnia;
            int najl = 0;
            for (int i = 0; i < tab.Length; i++)
                if (tab[i].powierzchnia > naj)
                {
                    naj = tab[i].powierzchnia;
                    najl = i + 1;
                }


            return najl;
        }

    }
    internal class Program
    {

        static void Main(string[] args)
        {
            Prostokat[] tab = { new Prostokat(4, 5),
            new Prostokat(5, 6),
            new Prostokat(6, 8) };
            foreach (Prostokat p in tab)
                p.Prezentuj();
            Console.WriteLine("Najwiekszy kwadrat to {0} kwadrat", Prostokat.Naj(tab));

            Console.ReadKey();
        }
    }

}
