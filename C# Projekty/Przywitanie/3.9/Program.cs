using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj l wierszy");
            int l = int.Parse(Console.ReadLine());
            int k = 0;  
            Console.WriteLine("Podaj a,b,c lub d");
            string draw = Console.ReadLine();
            switch (draw)
            {
                case "a":
                    for (int i = -1; i < l; i++)
                    {
                        for (int j = 0; j < k; j++)
                            Console.Write("*");
                        Console.WriteLine();
                        k++;
                    }
                    break;
                case "b":
                    for (int i = -1; i < l; i++)
                    {
                        for (int j = l; j > k; j--)
                            Console.Write("*");
                        Console.WriteLine();
                        k++;
                    }
                    break;
                case "c":
                    for (int i = -1; i < l; i++)
                    {
                       for (int j = l; j > k; j--)
                            Console.Write(" ");
                        for (int j = 0; j < k; j++)
                            Console.Write("*");
                        k++;
                        Console.WriteLine();

                    }
                    break;
                case "d":
                   
                    for (int j = 1; j < l; j++)
                        Console.Write("*");
                    for (int i = 1; i < l; i++)
                    {
                        Console.Write("*");
                        for ( int j = l-1; j > 0; j--)
                            Console.Write(" ");
                        Console.Write("*");
                        
                        Console.WriteLine();
                    }
                    for (int j = 0; j < l; j++)
                        Console.Write("*");
                    break;
            }
            Console.ReadKey();
        }
    }
}
