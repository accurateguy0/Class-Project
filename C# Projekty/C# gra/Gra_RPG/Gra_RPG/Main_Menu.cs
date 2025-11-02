using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Gra_RPG
{
    public class Menu
    {
        public int index;
        private string[] options;
        private string prompt;
        public Menu(string prompt, string[] options, int index)
        {
            this.prompt = prompt;
            this.options = options;
            this.index = index;
        }
        public void Display()
        {
            WriteLine(prompt);
            for (int i = 0; i < options.Length; i++)
            {
                string currentOption = options[i];
                if(i == index )
                {
                    ForegroundColor = ConsoleColor.Black;
                    BackgroundColor = ConsoleColor.White;
                }
                else
                {
                    ForegroundColor = ConsoleColor.White;
                    BackgroundColor = ConsoleColor.Black;
                }
                WriteLine($"{options[i]}");
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
                if(keyPressed == ConsoleKey.UpArrow && index > 0)
                {
                    index--;

                }
                else if (keyPressed == ConsoleKey.DownArrow && index < options.Length-1)
                {
                    index++;
                   
                }
            } while (keyPressed != ConsoleKey.Enter);
            return index;
        }
    }
}
