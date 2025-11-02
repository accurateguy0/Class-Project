using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Gra_RPG
{
    public class NavigationMenu
    {
        public int index;
        private List<string> options;
        private string prompt;
        public NavigationMenu(string prompt, List<string> options)
        {
            this.prompt = prompt;
            this.options = options;
        }
        public void Display()
        {
            WriteLine(prompt);
            foreach (string option in options)
            {
                if (options.IndexOf(option) == index)
                {
                    ForegroundColor = ConsoleColor.Black;
                    BackgroundColor = ConsoleColor.White;
                }
                else
                {
                    ForegroundColor = ConsoleColor.White;
                    BackgroundColor = ConsoleColor.Black;
                }
                WriteLine($">{option}");
            }
            ResetColor();
        }
        public int Run()
        {

            ConsoleKey keyPressed;
            do
            {
                Clear();
                Display();
                ConsoleKeyInfo keyInfo = ReadKey(true);
                keyPressed = keyInfo.Key; //zapdejtowanie "index" na bazie strzalek
                if (keyPressed == ConsoleKey.UpArrow && index > 0)
                {
                    index--;

                }
                else if (keyPressed == ConsoleKey.DownArrow && index < options.Count - 1)
                {
                    index++;

                }
            } while (keyPressed != ConsoleKey.Enter);
            return index;
        }
    }
}
