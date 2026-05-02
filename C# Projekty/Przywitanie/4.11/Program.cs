using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("podaj tekst");
            string tekst = Console.ReadLine();
            int liczbaa = 0;
            int liczbab = 0;
            int liczbac = 0;
            int liczbad = 0;
            int liczbae = 0;
            int liczbaf = 0;
            int liczbag = 0;
            int liczbah = 0;
            int liczbai = 0;
            int liczbaj = 0;
            int liczbak = 0;
            int liczbal = 0;
            int liczbam = 0;
            int liczban = 0;
            int liczbao = 0;
            int liczbap = 0;
            int liczbar = 0;
            int liczbas = 0;
            int liczbat = 0;
            int liczbau = 0;
            int liczbaw = 0;
            int liczbay = 0;
            int liczbaz = 0;
          
            foreach (char a in tekst) 
                if(a == 'a') liczbaa++;
            foreach (char b in tekst)
                if (b == 'b') liczbab++;
            foreach (char c in tekst)
                if (c == 'c') liczbac++;
            foreach (char d in tekst)
                if (d == 'd') liczbad++;
            foreach (char e in tekst)
                if (e == 'e') liczbae++;
            foreach (char f in tekst)
                if (f == 'f') liczbaf++;
            foreach (char g in tekst)
                if (g == 'g') liczbag++;
            foreach (char h in tekst)
                if (h == 'h') liczbah++;
            foreach (char i in tekst)
                if (i == 'i') liczbai++;
            foreach (char j in tekst)
                if (j == 'j') liczbaj++;
            foreach (char k in tekst)
                if (k == 'k') liczbak++;
            foreach (char l in tekst)
                if (l == 'l') liczbal++;
            foreach (char m in tekst)
                if (m == 'm') liczbam++;
            foreach (char n in tekst)
                if (n == 'n') liczban++;
            foreach (char o in tekst)
                if (o == 'o') liczbao++;
            foreach (char p in tekst)
                if (p == 'p') liczbap++;
            foreach (char r in tekst)
                if (r == 'r') liczbar++;
            foreach (char s in tekst)
                if (s == 's') liczbas++;
            foreach (char t in tekst)
                if (t == 't') liczbat++;
            foreach (char u in tekst)
                if (u == 'u') liczbau++;
            foreach (char w in tekst)
                if (w == 'w') liczbaw++;
            foreach (char y in tekst)
                if (y == 'y') liczbay++;
            foreach (char z in tekst)
                if (z == 'z') liczbaz++;
            if (liczbaa != 0)
                Console.Write("a - {0}", liczbaa);
            if (liczbab != 0)
                Console.Write("b - {0}", liczbab);
            if (liczbac != 0)
                Console.Write("c - {0}", liczbac);
            if (liczbad != 0)
                Console.Write("d - {0}", liczbad);
            if (liczbae != 0)
                Console.Write("e - {0}", liczbae);
            if (liczbaf != 0)
                Console.Write("f - {0}", liczbaf);
            if (liczbag != 0)
                Console.Write("g - {0}", liczbag);
            if (liczbah != 0)
                Console.Write("h - {0}", liczbah);
            if (liczbai != 0)
                Console.Write("i - {0}", liczbai);
            if (liczbaj != 0)
                Console.Write("j - {0}", liczbaj);
            if (liczbak != 0)
                Console.Write("k - {0}", liczbak);
            if (liczbal != 0)
                Console.Write("l - {0}", liczbal);
            if (liczbam != 0)
                Console.Write("m - {0}", liczbam);
            if (liczban != 0)
                Console.Write("n - {0}", liczban);
            if (liczbao != 0)
                Console.Write("o - {0}", liczbao);
            if (liczbap != 0)
                Console.Write("p - {0}", liczbap);
            if (liczbar != 0)
                Console.Write("r - {0}", liczbar);
            if (liczbas != 0)
                Console.Write("s - {0}", liczbas);
            if (liczbat != 0)
                Console.Write("t - {0}", liczbat);
            if (liczbau != 0)
                Console.Write("u - {0}", liczbau);
            if (liczbaw != 0)
                Console.Write("w - {0}", liczbaw);
            if (liczbay != 0)
                Console.Write("y - {0}", liczbay);
            if (liczbaz != 0)
                Console.Write("z - {0}", liczbaz);



            Console.ReadKey();     
        }
    }
}
