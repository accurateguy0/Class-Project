using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Cw_6._7
{
    internal class Program
    {
        static void KopiaLiczby(string sciezka, string nowyPlik)
        {
            string tekst = File.ReadAllText(sciezka);
            string[] wartosci = tekst.Split();
            foreach ( string i in wartosci )
                Console.Write(i + " ");
            int[] t = new int[wartosci.Length];
            
                for (int i = 0; i < wartosci.Length; i++)
                    t[i] = int.Parse(wartosci[i]);
         
            int ile = 0;

            for (int i = 0; i < wartosci.Length; i++)
                if (t[i] >= 0)
                    ile++;
            int[] tn = new int[ile];
            ile = 0;
            for (int i = 0; i < wartosci.Length; i++)
                if (t[i] >= 0)
                    tn[ile++] = t[i];


            File.WriteAllText(nowyPlik, string.Join(" ", tn));

        }
        static void Main(string[] args)
        {

            
                string sciezka = "Test.txt";
            if (!File.Exists(sciezka))
                {
                    string [] createText = { "2", "5", "-1", "0", "-4", "7" };
                    File.WriteAllLines(sciezka, createText);
                }
             
            string nowyPlik = "Nowy.txt";//w miejsce kropek wpisz scieszke dostepu

            if (File.Exists(nowyPlik))
                File.Delete(nowyPlik);
            KopiaLiczby(sciezka, nowyPlik);
        }
    }
}
