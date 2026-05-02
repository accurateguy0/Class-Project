using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Gra_RPG
{
    public class FightMenu : Scene
    {
       
        public int index;
        private List<Kungfu> options;
        private string prompt;
        public FightMenu(Game game, string prompt, List<Kungfu> options):base(game)
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
        public override void Run()
        {

        }
        public int RunDisplay()
        {

            ConsoleKey keyPressed;
            do
            {
                Clear();
                game.player.DisplayHealthBar();
                game.Bandit.DisplayHealthBar();
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
