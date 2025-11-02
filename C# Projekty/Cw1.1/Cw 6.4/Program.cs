using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Cw_6._4
{
    internal class Program
    {
        static bool Palindrom(string t)
        {
            if ( t.Length <= 1)
                return true;
            if (t[0] == t[t.Length - 1])
                return Palindrom(t.Substring(1, t.Length - 2));
            else return false;
        }
        static void Main(string[] args)
        {
            string t =  "ala";
            Console.WriteLine(Palindrom(t));
            Console.ReadKey();
        }
    }
}
