using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw_7._2
{
    class Student
    {
       public string nazwisko, imie, kierunek;
       public int album, semestr;
    }
    internal class Program
    {
        public static Student Utworz(string nazwisko, string imie, string kierunek, int album, int semestr)
        {
            Student s = new Student();
            s.nazwisko = nazwisko;
            s.imie = imie;  
            s.kierunek = kierunek;
            s.album = album;
            s.semestr = semestr;
            return s;
        }
        static void Promocja(Student s)
        {
            if (s.semestr >= 8)
                Console.WriteLine("Pomylka to absolwent");
            if(s.semestr < 8)
                s.semestr++;
        }
        static void Wyswietl(Student s)
        {
            Console.WriteLine("Student: {0} {1} \n kierunek: {2} \n nr albumu: {3} \n semestr: {4}", s.nazwisko, s.imie, s.kierunek, s.album, s.semestr );
        }
        static void Main(string[] args)
        {
            Student A = Utworz("Kowalski", "Dawid", "Informatyka", 22017, 1);
            Student B = Utworz("Przemyk", "Anna", "Bezpieczenstwo Zywnosci", 11905, 1);
            Wyswietl(B);
            Promocja(A);
            Promocja(A);
            Promocja(A);
            Promocja(A);
            Promocja(A);
            Promocja(A);
            Promocja(A);
            Promocja(A);
            Wyswietl(A);
            Console.ReadKey ();
        }
    }
}
