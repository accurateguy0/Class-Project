using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw_4._6
{
    internal class Program
    {
        static void Podobne( params int[] tab)
        {
            for (int i = 0; i < tab.Length; i++)
                for (int j = 0; j < tab.Length; j++)
                    if (tab[i] == tab[j])
                    {
                        Console.WriteLine("ma podobne elementy");
                        break;
                    }
                       
        }
        static void Main(string[] args)
        {
            int[] tab = new int[] { 1, 2, 3, 1 };
            Podobne(tab);
            
            Console.ReadKey();
        }
    }
}
