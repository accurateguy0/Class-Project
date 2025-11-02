using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Gra_RPG
{
    public class TitleScene : Scene
    {
        public TitleScene(Game game) : base(game)
        {

        }
        public override void Run()
        {
            string prompt = @"
 ██▀███   ██▓███    ▄████      ▄████  ▄▄▄       ███▄ ▄███▓▓█████ 
▓██ ▒ ██▒▓██░  ██▒ ██▒ ▀█▒    ██▒ ▀█▒▒████▄    ▓██▒▀█▀ ██▒▓█   ▀ 
▓██ ░▄█ ▒▓██░ ██▓▒▒██░▄▄▄░   ▒██░▄▄▄░▒██  ▀█▄  ▓██    ▓██░▒███   
▒██▀▀█▄  ▒██▄█▓▒ ▒░▓█  ██▓   ░▓█  ██▓░██▄▄▄▄██ ▒██    ▒██ ▒▓█  ▄ 
░██▓ ▒██▒▒██▒ ░  ░░▒▓███▀▒   ░▒▓███▀▒ ▓█   ▓██▒▒██▒   ░██▒░▒████▒
░ ▒▓ ░▒▓░▒▓▒░ ░  ░ ░▒   ▒     ░▒   ▒  ▒▒   ▓▒█░░ ▒░   ░  ░░░ ▒░ ░
  ░▒ ░ ▒░░▒ ░       ░   ░      ░   ░   ▒   ▒▒ ░░  ░      ░ ░ ░  ░
  ░░   ░ ░░       ░ ░   ░    ░ ░   ░   ░   ▒   ░      ░      ░   
   ░                    ░          ░       ░  ░       ░      ░  ░
Welcome to our game! Step into a world where strength flows through discipline, 
and every choice leads you deeper into the heart of kung-fu legend.
                                                                 
";
            string[] option = { "Play", "About", "Exit" };
            Menu menu = new Menu(prompt, option, 0);
            int index = menu.Run();

            switch (index)
            {
                case 0:
                    game.CharacterCreation.Run();
                    break;
                case 1:
                    OptionsAbout();
                    break;
                case 2:
                    ExitGame();
                    break;
            }
            ReadKey(true);
        }
        private void ExitGame()
        {
            Clear();
            WriteLine(" Press any key to exit");
            ReadKey(true);
            Environment.Exit(0); // ten kod powoduje ze terminal zamyka sie, a nr 0 oznacza ze wyjscie zakonczono sukcesem
        }
        private void OptionsAbout()
        {
            Clear();
            Console.WriteLine(@"Created by Dawid Kowalski with the help of: Kinga Łachacz & Szymon Jakubowski");
            Console.WriteLine("Press any key to go back");
            ReadKey(true);
            Run();
        }
        [Obsolete]
        private void OptionsPlay() // ta metoda jest stara więc możemy ją zaznaczyć atrybutem "OBSOLETE", pokazując panu naszą obszerną wiedzę i że słuchaliśmy na lekcji, brakuje tu wielowątkowości, wydarzenia(można użyć ją do symulacji ładowania gry) i delegatów, mamy polimorfizm, dziedziczenie, enkapsulację i generyczne
        {
            Clear();
            Console.WriteLine("game is in maintenance");
            ReadKey(true);
            ExitGame();
        }

    }
}
