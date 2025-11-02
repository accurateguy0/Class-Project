using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Gra_RPG
{
    public static class ConsoleUtils
    {
        public static void WaitForKey()
        {
            ConsoleKey key;
            do
            {
                ConsoleKeyInfo keyinfo = ReadKey(true);
                key = keyinfo.Key;
            } while (KeyAvailable);
            

        }
        public static void QuitConsole()
        {
            WriteLine("Press any key to exit.");
            ReadKey(false);
            Environment.Exit(0);
        }
        public static void ClearLine() // ten kod miał usuwać linię, nie próbowałem metody zadziałania, ale na StackOverflow mówili że działa
        {
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, Console.CursorTop - 1);
        }
    }
}
