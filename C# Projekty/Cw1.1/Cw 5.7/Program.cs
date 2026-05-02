using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw_5._7
{
    internal class Program
    {
        static void Unormowanie(double[] t)
        {
            double s = 0;
            for (int i = 0; i < 10; i++)
            {
                s += t[i];
            }
            if (s == 0)
                throw new Exception("nie da sie unormowac");
            for (int i = 0; i < 10; i++)
            {
                t[i] /= s;
            }
        }
        static void Main(string[] args)
        {
            Random rnd = new Random();
            double[] t = new double[5];
            for (int i = 0; i < t.Length; i++)
                t[i] = rnd.Next(1);
            try
            { 
            Unormowanie(t);
                double suma = 0;
                for (int i = 0; i < t.Length; i++)
                {
                    Console.WriteLine(t[i]);
                    suma += t[i];
                }
            }
            catch (Exception e) 
            {
                Console.Write(e.Message);
            }
            Console.ReadKey();
        }
    }
}
