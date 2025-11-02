using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw_7._5
{
    class Kontakt
    {
        public string numer;
        public string imie, nazwisko;
    }
    class Telefony
    {
        public Kontakt[] lista = new Kontakt[100];
        public int n = 0; //liczba kontaktow
    }

    internal class Program
    {
       static Telefony Wczytaj (string path)
        {
            Telefony t = new Telefony();
            if(File.Exists(path))
            {
               
                string [] dane = File.ReadAllLines (path);
                int m = dane.Length;
                Kontakt [] lista = new Kontakt[m]; 
                for (int i = 0; i < m; i = i + 3)
                {
                    Kontakt k = new Kontakt();
                    k.imie = dane[i];
                    k.nazwisko = dane[i + 1];
                    k.numer = dane[i + 2];
                    lista[i/3] = k;
                }
                t.lista = lista;
                t.n = m / 3;
            }
            return t;
        }
        
        static void Zapisz(Telefony t,string path)
        {
            string[] dane = new string[t.n * 3];
            for (int i = 0;i < t.n;i++)
            {
                dane[i*3] = t.lista[i].imie;
                dane[i*3 + 1] = t.lista[i].nazwisko;
                dane[i*3 + 2] = t.lista[i].numer;
            }
            File.WriteAllLines (path, dane);
            return;
        }
        static void Dodaj(Telefony t, Kontakt k)
        {
            t.lista[t.n] = k;
            t.n++;
        }
        static void Usun(Telefony t, string s)
        {

            if (t.lista != null)
            {
                int usunieto = -1;
                for (int i = 0; i < t.lista.Length; i++)
                {
                    if (t.lista[i].imie == s)
                    {
                        usunieto = i;
                        break;
                    }
                        
                }
                if (usunieto != -1)
                    for (int i = usunieto; i < t.n; i++)
                    {
                        t.lista[i] = t.lista[i + 1];
                        t.lista[t.n - 1] = null;
                        t.n--;
                    }
            }
        }
        static bool CzyPoprawny(string s)
        {
            if(s.Length != 9) return false;
            for (int i = 0; i <= s.Length - 1; i++)
                if(!Char.IsDigit(s[i]))
                    return false;
            return true;
        }
        static int Wyszukaj(Telefony t, string s)
        {
          
            if (t.lista != null)
            {
                for (int i = 0; i < t.lista.Length; i++)
                {
                    if (t.lista[i].imie == s)
                    {
                        return i;
                    }

                }
            }
            return -1;
        }
         static string Wypisz(Telefony t)
        {
            string u = "Ksiazka telefoniczna\n";
            if (t.lista != null)
                for (int i = 0; i < t.n; i++)
                    u += t.lista[i].imie + " " + t.lista[i].nazwisko + " " + t.lista[i].numer + " \n";
            else u += " lista jest pusta\n"; //nie dziala
                    return u;
        }
        static void Main(string[] args)
        {
            char c;
            string s, z, a;
            string path = "t.txt";

            Telefony t = Wczytaj(path);

            Console.WriteLine("Witamy w ksiazce telefonicznej");
            do
            {
                Console.WriteLine("wcisnij a aby wyswietlic numery telefonu\r\n" + "wcisnij b aby dodac numer telefonu\r\n" + "wcisnij c aby usunac numer telefonu\r\n" + "wcisnij d aby wyszukac osobe\r\n" + "wcisnij k aby zakonczyc\r\n");
                c = Console.ReadKey(true).KeyChar;

                switch(c)
                {
                    case 'a':
                        Console.WriteLine(Wypisz(t));
                        break;
                    case 'b':
                        Console.WriteLine("podaj imie");
                        s = Console.ReadLine();
                        Console.WriteLine("podaj nazwisko");
                        z = Console.ReadLine();
                        Console.WriteLine("podaj numer");
                        a = Console.ReadLine();
                        if (!CzyPoprawny(a))
                        {
                            Console.WriteLine("podano zly numer");
                            break;
                        }
                            
                        Kontakt k = new Kontakt();
                        k.imie = s;
                        k.nazwisko = z; 
                        k.numer = a;
                        Dodaj(t, k);
                        break;
                    case 'c':
                        Console.WriteLine("podaj imie osoby ktorej chcesz usunac");
                        s = Console.ReadLine();
                        Usun(t, s);
                        break;
                    case 'd':
                        Console.WriteLine("podaj imie osoby ktorej chcesz znalezc");
                        s = Console.ReadLine();
                        int d = Wyszukaj(t, s);
                        Console.WriteLine("znaleziono {0} w pozycji {1}. {2} {3}", t.lista[d].imie, d, t.lista[d].nazwisko, t.lista[d].numer);
                        break;
                    default: break;
                }
            }while (c != 'k');

            Zapisz(t, "t.txt");
        }
    }
}
