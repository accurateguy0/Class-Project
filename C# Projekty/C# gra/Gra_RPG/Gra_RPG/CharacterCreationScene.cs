using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Gra_RPG
{
    public class CharacterCreationScene : Scene
    {
        public int i = 0;
        public CharacterCreationScene(Game game) : base(game)
        { }
        public override void Run()
        {
            game.player.SkillPoints = 8;
            string prompt = "Choose gender:";
            string[] option = { "Male", "Female" };
            Menu menu = new Menu(prompt, option, 0);
            int index = menu.Run();
            switch(index)
            {
                case 0:
                    game.player.Gender = "Male";
                    WriteLine($"you're now a {game.player.Gender}!");
                    ConsoleUtils.WaitForKey();
                    NameCreator();
                    return;
                case 1:
                    game.player.Gender = "Female";
                    WriteLine($"you're now a {game.player.Gender}!");
                    ConsoleUtils.WaitForKey();
                    NameCreator();
                    break;

            }
                
            
        }
        public void NameCreator()
        {
            string prompt = $"Create your name";
            string[] options = { "Random", "Custom" };
            Menu menu = new Menu(prompt, options, 0);
            int index = menu.Run();
            switch (index)
            {
                case 0:
                    RandomNameCreator();
                    break;
                case 1:
                    CustomNameCreator();
                    break;
            }
            StatCreator();
        }
        public void CustomNameCreator()
        {
            Clear();
            WriteLine("Type your name");
            game.player.Name = Console.ReadLine();
            if (game.player.Name.Length == 0 & game.player.Name.Length > 20)
            {
                WriteLine("invalid name or too long name");
                ConsoleUtils.WaitForKey();
                CustomNameCreator();
            }
            WriteLine($"Your name is: {game.player.Name}");
        }
        public void RandomNameCreator()
        {
            Random rnd = new Random();
            string[] names;
            if (game.player.Gender == "Female") 
            {
                names = [ "Sarah Gottfried", "Anna Crumb", "Immordina Yang"];
            }
            else
            { 
                names = ["Elvis Pretzel", "Hoo Le Phuc", "Bob Parsley"];
            }
               
            string prompt = $"Your random name is: {game.player.Name = names[rnd.Next(0, 3)]}";
            string[] options = { "Randomize", "OK" };
            Menu menu = new Menu(prompt, options, 0);
            int index = menu.Run();
            switch (index)
            {
                case 0:
                    RandomNameCreator();
                    break;
                case 1:
                    break;
            }
        }
        public void StatCreator()
        {

         string prompt = $@"Choose your stats. Your remianing skill points: {game.player.SkillPoints}
HP: {game.player.Health} ATK : {game.player.Attack}";
            if (game.player.SkillPoints > 0)
            {
                string[] options = { "HP", "ATK" };
                Menu menu = new Menu(prompt, options, i);
                int index = menu.Run();
                switch (index)
                {
                    case 0:
                        game.player.Health += 10;
                        game.player.SkillPoints -= 1;
                        StatCreator();
                        break;
                    case 1:
                        game.player.Attack += 1;
                        i = 1;
                        game.player.SkillPoints -= 1;
                        StatCreator();
                        break;
                }
            }
            else
            {
                string[] options = { "HP", "ATK", "Continue" };
                Menu menu = new Menu(prompt, options, i);
                int index = menu.Run();
                switch (index)
                {
                    case 0:
                        WriteLine("You don't have enough skill points");
                        ConsoleUtils.WaitForKey();
                        StatCreator();
                        break;
                    case 1:
                        WriteLine("You don't have enough skill points");
                        i = 1;
                        ConsoleUtils.WaitForKey();
                        StatCreator();
                        break;
                    case 2:
                        WriteLine("Game starts..");
                        ConsoleUtils.WaitForKey();
                        game.Act1.Run();
                        break;
                }
            }
        }
    }
    
    
}
