using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tab1 = new int[10];
            Console.WriteLine("podaj 10 elementow tab1");
            for (int i = 0; i < 10; i++)
            {
               tab1[i] = int.Parse (Console.ReadLine());
            }
            int[] tab2 = new int[10];
            for (int i = 0; i < 10; i++)
            {
                if(tab1[i] >= 0)
                Array.Copy(tab1, i, tab2, i, 1);
            }
            foreach (int i in tab2)
            Console.Write(i + ", " );
           Console.ReadKey();
        }
    }
}
