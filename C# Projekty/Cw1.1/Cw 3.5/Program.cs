using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw_3._5
{
    internal class Program
    {
        enum PoryRoku { Wiosna, Lato, Jesień, Zima }
        static void Main(string[] args)
        {
            Console.WriteLine("zgadnij jaka pore lubie. 0/ Wiosna, 1/ Lato, 2/ Jesien, 3/ Zima,");
            int l = int.Parse(Console.ReadLine());
            PoryRoku poraUlubiona = PoryRoku.Wiosna;
            PoryRoku poraNielubiona = PoryRoku.Jesień;
            Console.WriteLine((PoryRoku)l);
            if ((PoryRoku)l == poraUlubiona)
            Console.WriteLine("lubie ta pore");
                else if ((PoryRoku)l == poraNielubiona) 
            Console.WriteLine("nie lubie ta pore");
            else Console.WriteLine((PoryRoku)l + "Hmm....") ; 
            Console.ReadKey();
        }
    }
}
