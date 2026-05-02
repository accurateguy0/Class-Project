using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw_7._4
{
    class Samochod
    {
        public string marka, model;
        public int rok, przebieg;
    }
    internal class Program
    {
        static Samochod Utworz( string marka, string model, int rok, int przebieg )
        {
            Samochod s = new Samochod();
            s.marka = marka;    
            s.model = model;
            s.rok = rok;
            s.przebieg = przebieg;
            return s;
        }
        static void Wyswietl(Samochod s)
        {
            Console.WriteLine("samochod marki {0} modelu {1}, rok {2}, przebieg {3}", s.marka, s.model, s.rok, s.przebieg);
        }
        static Samochod [] Wyszukaj(Samochod [] s, string w)
        {
            
            int n = 0;
            for (int i = 0; i < s.Length; i++)
                if (s[i].marka == w)
                    n++;
            Samochod [] Wyszukane = new Samochod[n];
            int k = 0;
            for (int i = 0; i < s.Length; i++)
                if (s[i].marka == w)
                    Wyszukane[k++] = s[i];
            return Wyszukane;   
        }
        static void Zapisz(Samochod [] s, string plik)
        {
            if(File.Exists(plik))
                File.Delete(plik);
            for (int i = 0;i < s.Length;i++)
            {
                string auto =  s[i].marka + ", " + s[i].model + ", " + s[i].rok + ", " + s[i].przebieg;
                File.AppendAllText(plik, auto + "\r\n");
            }
               
        }
        static Samochod [] Wczytaj(string plik)
        {
           string [] tekst = File.ReadAllLines(plik);
            Samochod [] auta = new Samochod[tekst.Length];
            for (int i = 0; i < tekst.Length; i++)
            {
                string [] dane = tekst[i].Split(',');
                auta[i] = Utworz(dane[0], dane[1], int.Parse(dane[2]), int.Parse(dane[3]));
            }
            return auta;
        }
        static void Main(string[] args)
        {
            Samochod A = Utworz("Audi", "A6", 2004, 160000);
            Wyswietl(A);
            
            Samochod [] flota = {A, Utworz("Audi", "SQ5", 2022, 41000), Utworz("Volswagen", "Tiguan", 2025, 5)}; 
            Console.WriteLine("Wyszukanie samochodu po marce. podaj marke");
            string w = Console.ReadLine();
            Samochod [] Wyszukany = Wyszukaj(flota, "Audi");
            for(int i = 0; i < Wyszukany.Length; i++)
               Wyswietl(Wyszukany[i]);
            Zapisz(flota, "auta.txt");
            Samochod [] odczytane = Wczytaj("auta.txt");
            for (int i = 0; i < odczytane.Length; i++)
                Wyswietl(odczytane[i]);
            Console.ReadKey();
        }
    }
}
