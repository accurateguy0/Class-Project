using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra_RPG
{
    public class CreditsScene : Scene
    {
        public CreditsScene(Game game) : base(game) 
        {

        }
        public override void Run()
        {
            game.Inventory.Clear();
            game.FightInventory.Clear();
            game.Sound.syncStop();
            string prompt = @"Thanks for playing the game.
========= Credits =========
> Microsoft Documentation https://learn.microsoft.com/en-us/dotnet/csharp/
> Michael Hadley Intro to C# https://www.youtube.com/playlist?list=PL-LDQE9x9hLwldZPPGwqXixr-_DfINfxk
> ascii art with the help of: https://www.asciiart.eu/
> ascii art text-to-art converter: https://patorjk.com/software/taag/#p=display&f=Graffiti&t=Type%20Something%20
> Game Developer ""demystifying attributes"": https://www.gamedeveloper.com/design/demystifying-attributes-c-s-under-utilized-superpower-for-game-development
> MP3 to .wav converter: https://audio.online-convert.com/convert/mp3-to-wav
> text scrolling https://freesound.org/search/?q=text+scroll
> damage sound https://pixabay.com/sound-effects/search/damage_grunt
> play sound asynchronously https://stackoverflow.com/questions/1161229/how-to-use-system-media-soundplayer-to-asynchronously-play-a-sound-file
> building an inventory: https://medium.com/@walshejohnnyw7/building-an-inventory-system-in-c-exploring-interfaces-generics-and-the-liskov-substitution-4f4c2aadd0f0
Would you like to play again?";
            string[] options = { "Yes", "No" };
            Menu menu = new Menu(prompt, options, 0);
            int index = menu.Run();
            switch(index)
            {
                case 0:
                    game.Start();
                    break;
                case 1:
                    ConsoleUtils.QuitConsole();
                    break;
            }
        }
    }
}
