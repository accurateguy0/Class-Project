using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Przykladf
{
    class Kontakt
    {
        public string nazwisko;
        public string telefon;
    }

    class Telefony
    {
        public Kontakt[] lista = new Kontakt[100];//tablica kontaktów
        public int n = 0; // liczba kontaktów
    }
    internal class Program
    {
        public static Telefony Wczytaj(string path)
        {
            Telefony t = new Telefony();
            if (File.Exists(path))
            {
                string[] dane = File.ReadAllLines(path);
                int m = dane.Length;
                Kontakt[] lista = new Kontakt[m];
                // mozna lączyć rekord w jeden string a przy odczycie robić split
                for (int i = 0; i < m; i = i + 2)
                {
                    Kontakt k = new Kontakt();
                    k.nazwisko = dane[i];
                    k.telefon = dane[i + 1];
                    lista[i / 2] = k;
                }
                t.lista = lista;
                t.n = m / 2;
            }
            return t;
        }

        public static void Zapisz(string path, Telefony t)
        {
            // mozna lączyć rekord w jeden string a przy odczycie robić split
            string[] dane = new string[t.n * 2];
            for (int i = 0; i < t.n; i++)
            {
                dane[2 * i] = t.lista[i].nazwisko;
                dane[2 * i + 1] = t.lista[i].telefon;
            }
            File.WriteAllLines(path, dane);
            return;
        }

        public static string Wypisz(Telefony t)
        {
            string telefony = "Książka telefoniczna\n";
            if (t.lista != null)
                for (int i = 0; i < t.n; i++)
                    telefony += t.lista[i].nazwisko + " " + t.lista[i].telefon + "\n";
            else telefony += "lista jest pusta\n";
            return telefony;
        }

        public static void Dodaj(Telefony t, Kontakt k)
        {
            if (t.n == t.lista.Length - 1)
            {
                //Console.WriteLine("brak miejsca");
                Kontakt[] tmp = new Kontakt[t.n + 20];
                for (int i = 0; i < t.n; i++)
                    tmp[i] = t.lista[i];
                t.lista = tmp;
            }

            t.lista[t.n] = k;
            t.n = t.n + 1;
        }

        // zakładamy unikalność nazwiska
        public static int Wyszukaj(Telefony t, string osoba)
        {
            if (t.lista != null)
            {
                for (int i = 0; i < t.n; i++)
                {
                    if (osoba == t.lista[i].nazwisko)
                    {
                        return i;
                    }
                }
            }
            return -1; // nie znaleziono
        }

        public static bool CzyPoprawny(string z)
        {
            if (z.Length != 9) return false;
            for (int i = 0; i < z.Length; i++)
                if (!Char.IsDigit(z[i])) return false;
            return true;
        }

        public static int Usun(Telefony t, string osoba)
        {
            if (t.lista != null)
            {
                int usuwany = -1;
                for (int i = 0; i < t.n; i++)
                {
                    if (osoba == t.lista[i].nazwisko)
                    {
                        usuwany = i;
                        break;
                    }
                }

                if (usuwany != -1)
                {
                    for (int i = usuwany; i < t.n - 1; i++)
                        t.lista[i] = t.lista[i + 1];
                    t.lista[t.n - 1] = null;
                    t.n--;
                }
                return usuwany;
            }
            return -1; // nie znaleziono
        }
        static void Main(string[] args)
        {
            char c;
            string s, z;
            string path = "Telefony.txt"; //plik zapisze sie w tym samym katalogu, co projekt

            Telefony t = Wczytaj(path);

            Console.WriteLine("witamy w programie książka telefoniczna");

            do
            {
                Console.WriteLine("\nAby wypisać listę wciśnij a" +
                                  "\nAby wpisać kontakt wciśnij b" +
                                  "\nAby wyszukać osobę wciśnij c" +
                                  "\nAby usunąć osobę wciśnij d" +
                                  "\nAby zakończyć wciśnij k\n");
                c = Console.ReadKey(true).KeyChar;

                //przetwarzanie polecenia użytkownika
                switch (c)
                {
                    case 'a':
                    case 'A':
                        Console.WriteLine(Wypisz(t));

                        break;
                    case 'b':
                    case 'B':
                        Console.WriteLine("podaj nazwisko");
                        s = Console.ReadLine();
                        //tu w razie czego sprawdzanie poprawności danych
                        if (Wyszukaj(t, s) != -1)
                        {
                            Console.WriteLine("kontakt już wpisany");
                            break;
                        }

                        Console.WriteLine("podaj telefon");
                        z = Console.ReadLine();
                        //tu w razie czego sprawdzanie poprawności danych
                        if (!CzyPoprawny(z))
                        {
                            Console.WriteLine("telefon niepoprawny");
                            break;
                        }
                        Kontakt k = new Kontakt();
                        k.nazwisko = s;
                        k.telefon = z;
                        Dodaj(t, k);
                        break;
                    case 'c':
                    case 'C':
                        Console.WriteLine("podaj nazwisko do wyszukania");
                        s = Console.ReadLine();
                        int wynik = Wyszukaj(t, s);
                        if (wynik >= 0)
                        {
                            Console.WriteLine("znaleziono na pozycji " + wynik +
                                              " - " + t.lista[wynik].nazwisko +
                                              " - " + t.lista[wynik].telefon);
                        }
                        else Console.WriteLine("nie znaleziono osoby " + s);
                        Console.WriteLine();
                        break;
                    case 'd':
                    case 'D':
                        Console.WriteLine("podaj nazwisko");
                        s = Console.ReadLine();
                        if (Usun(t, s) >= 0) Console.WriteLine("usunięto " + s);
                        else Console.WriteLine("nie znaleziono osoby " + s);
                        break;
                }
            }
            while (!(c == 'k' || c == 'K'));

            Zapisz(path, t);

        }
    }
}
