using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._4
{
    public class LicznikEnergii
    {
        public int energia { get; set; }
        public int czas {  get; set; }
        public int zuzycie {  get; set; }
        public int PozostaloEnergii
        {
            get{ return energia - zuzycie * czas; }
        }
        public int ZuzytoEnergii
        {
            get { return energia - PozostaloEnergii; }
        }
        public LicznikEnergii(int ener, int cz, int zuz)
        {
            energia = ener;
            czas = cz;
            zuzycie = zuz;
        }
        public void Pokaz()
        {
            Console.WriteLine("energia poczatkowa: {0}, czas: {1}, Pozostalo Energii:{2}, ZuzytoEnergii: {3}", energia, czas, PozostaloEnergii, ZuzytoEnergii);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("podaj liczbe energii");
            int energia = int.Parse(Console.ReadLine());
            Console.WriteLine("podaj zuzycie energii");
            int zuzycie = int.Parse(Console.ReadLine());
            int n = 1;
          
                Console.WriteLine("podaj czas");
                int czas = int.Parse(Console.ReadLine());
               LicznikEnergii e0 = new LicznikEnergii(energia, czas, zuzycie);
            e0.Pokaz();
            
           Console.ReadKey(); 

        }
    }
}
