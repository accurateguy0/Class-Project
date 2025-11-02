using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Towar
    {
        public string nazwa, producent;
        public double cena;
        public static Towar Utworz(string n, string p, double c)
        {
            Towar t = new Towar();
            t.nazwa = n;
            t.producent = p;
            t.cena = c;
            return t;
        }
        
        public static void Zapisz (string plik, Towar[] t )
            {
            
            if (File.Exists(plik))
                File.Delete(plik);
            for(int i = 0; i < t.Length; i++) 
            {
                string towar = t[i].nazwa + "/ " + t[i].producent + "/ " + t[i].cena;
                File.AppendAllText(plik, towar + "\r\n");
            }
           

            }
        public static Towar [] Wczytaj(string plik)
        {
            string[] dane = File.ReadAllLines(plik);
            Towar[] t = new Towar[dane.Length];
            for(int i = 0; i < dane.Length;i++)
            {
                string[] tekst = dane[i].Split('/');
                t[i] = Utworz(tekst[0], tekst[1], double.Parse(tekst[2]));
            }
            return t;
        }
       public static Towar [] Wyszukaj(string producent, Towar[] t)
        {
            int n = 0;
            for (int i = 0; i < t.Length; i++)
            {
                if (t[i].producent == producent)
                {
                    n++;
                   
                }

            }

            Towar[] wyszukane = new Towar[n];
            int m = 0;
            for (int i = 0; i < wyszukane.Length; i++)
            {
                if (t[i].producent == producent)
                {
                    wyszukane[m++] = t[i];
                   
                }
            }
            
            return wyszukane;   
        }
        public static void Wyswietl(Towar t)
        {
            if(t != null)
            Console.WriteLine("{0} {1} {2:C}", t.nazwa, t.producent, t.cena);
        }
    }
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Towar[] tab = { Towar.Utworz("Mikser", "Bosch", 500.00), Towar.Utworz("Trzepaczka", "Siemens",10.00), Towar.Utworz("Telewizor", "Sony", 2000.00) };
            Towar.Zapisz("Towar.txt", tab);

            Towar[] odczytane = Towar.Wczytaj("Towar.Txt"); 
            for(int i = 0;i < odczytane.Length; i++)
            {
                Towar.Wyswietl(odczytane[i]);
            }
            Console.WriteLine("wyszukane bosch");
            Towar [] wyszukane = Towar.Wyszukaj("Bosch", tab);
           
            for(int i = 0; i < wyszukane.Length;i++)
                Towar.Wyswietl(wyszukane[i]);

            Console.ReadKey ();
        }
    }
}

