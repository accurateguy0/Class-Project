using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._11
{
    static internal class MenuProste
    {
        public static void StartMenuProste()
        {
            Console.Title = "ProsteMenu";

            while (true)
            {
                Console.Clear();
                Console.WriteLine(">>> Przykladowe Menu <<<");
                Console.WriteLine("1 - Opcja pierwsza");
                Console.WriteLine("2 - Opcja druga");
                Console.WriteLine("3 - Koniec");

                ConsoleKeyInfo klawisz = Console.ReadKey();
                switch (klawisz.Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear(); opcjaWBudowie(); break;
                    case ConsoleKey.D2:
                        Console.Clear(); opcjaWBudowie(); break;
                        case ConsoleKey.Escape:
                        case ConsoleKey.D3:
                        Environment.Exit(0); break;
                    default: break;
                }
            }
        }
        static void opcjaWBudowie()
        {
            Console.Write("opcja w budowie");
            Console.ReadKey();
        }
    }
}
