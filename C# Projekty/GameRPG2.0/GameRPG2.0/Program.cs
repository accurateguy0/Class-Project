using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Gra_RPG
{
    internal class Program // ktoś powiedział, że ogólną zasadą jest to aby jak najmniej wypełnić klasę Program i/lub metodę Main
    {
        static void Main(string[] args) 
        {
            //string prompt = "welcome to the rpg game";
            //string[] option = { "play", "options", "exit" };
            //menu menu = new menu(prompt, option);
            //menu.display();
            CursorVisible = false;
            Game myGame = new Game();
            myGame.Start(); // tutaj aktywuje się klasa Game, co powoduje kaskadę wydarzeń
            ReadKey(true);
        }
    }
}
