using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("podaj tekst");
                string atekst = Console.ReadLine();
            string tekst = atekst.ToUpper();
            string szyfr = "GADERYPOLUKI";
            string TekstZaszyfrowany = String.Empty;
            int x;
            for (int i = 0; i < tekst.Length; i++)
                {
                x = szyfr.IndexOf(tekst[i]);
                if (tekst[i] != 'G' && tekst[i] != 'A' && tekst[i] != 'D' && tekst[i] != 'E' &&  tekst[i] != 'R' && tekst[i] != 'Y' && tekst[i] != 'P' && tekst[i] != 'O' && tekst[i] != 'L' && tekst[i] != 'U' && tekst[i] != 'K' && tekst[i] != 'I')
                {
                    TekstZaszyfrowany += tekst[i];
                }   
                else
                {
                   // foreach (char c in szyfr)
                       // if (c == tekst[i])
                      
                        {
                            if (x % 2 == 0)
                                TekstZaszyfrowany += szyfr[x + 1];
                            else
                                TekstZaszyfrowany += szyfr[x - 1];
                        }
                    
                }
               
                       
               
                            

                    
                 

                }
           Console.WriteLine(TekstZaszyfrowany);
            Console.ReadKey();
        }
    }
}
