using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Gra_RPG
{
    public class InventoryMenu
    {
        public int index;
        private List<Kungfu> options; // robiłem 3 inne menu, aby każdego umieścić inaczej i gdzie indziej, ale mogę się mylić, kod jest bardziej do demo, a tak to trzeba ją wyszlifować
        private string prompt;
        public InventoryMenu(string prompt, List<Kungfu> options)
        {
            this.prompt = prompt;
            this.options = options;
        }
        public void Display()
        {
            WriteLine(prompt);
            foreach (Kungfu item in options)
            {
                if (options.IndexOf(item) == index)
                {
                    ForegroundColor = ConsoleColor.Black;
                    BackgroundColor = ConsoleColor.White;
                }
                else
                {
                    ForegroundColor = ConsoleColor.White;
                    BackgroundColor = ConsoleColor.Black;
                }
                WriteLine($">{item.Name}");
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
                else if (keyPressed == ConsoleKey.DownArrow && index < options.Count-1)
                {
                    index++;

                }
            } while (keyPressed != ConsoleKey.Enter);
            return index;
        }
    }
}
