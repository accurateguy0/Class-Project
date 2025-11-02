using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw_5._5
{
    internal class Program
    {
        static void ParzNieParz(ref int[]a, ref int[] b)
        {
            int j = 0;  
            int k = 0;
            for(int i  = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                    j++;
                else
                    k++;
            }
            for (int i = 0; i < b.Length; i++)
            {
                if (b[i] % 2 == 0)
                    j++;
                else
                    k++;
            }
            int [] m = new int[j];
            int [] n = new int[k];
            int iparz = 0, nieparz = 0; 
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    m[iparz] = a[i];
                    iparz++;
                }
                else
                {
                    n[nieparz] = a[i];
                    nieparz++;
                }
            }
                    

            for (int i = 0; i < b.Length; i++)
            {
                if (b[i] % 2 == 0)
                {
                    m[iparz] = b[i];
                    iparz++;
                }
                else
                {
                    n[nieparz] = a[i];
                    nieparz++;
                }
            }
                
                   
            a = m;
            b = n;
        }
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 5 };
            int[] b = { 2, 4, 9, 0 };
            ParzNieParz(ref a, ref b);
            Console.WriteLine("\n Parzyste:");
            for (int i = 0; i < a.Length; i++)
                Console.Write(a[i] + " ");
            Console.WriteLine("\n Nieparzyste:");
            for (int i = 0; i < b.Length; i++)
                Console.Write(b[i] + " ");
            Console.ReadKey();
        }
    }
}
