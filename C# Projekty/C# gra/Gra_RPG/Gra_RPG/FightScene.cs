using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;

namespace Gra_RPG
{
    public class FightScene : Scene
    {
        public FightScene(Game game):base(game)
        { 

        }
        public override void Run()
        {
            game.Sound.syncRun("03 - battle_qiecuo.wav");
            while (game.player.Health > 0 & game.Bandit.Health > 0)
            {
                string prompt = $"What's your move?:";
                FightMenu fightMenu = new FightMenu(game, prompt, game.FightInventory);
                int index = fightMenu.RunDisplay();
                if (game.FightInventory[index].GetType().Equals(typeof(Fightkungfu)) )
                {
                    game.player.Technique = game.FightInventory[index].Name;
                    game.player.Attack += game.FightInventory[index].AddStat;
                    game.player.Fight(game.Bandit);
                    game.player.Attack -= game.FightInventory[index].AddStat;
                    if (game.Bandit.Gender == "Female") 
                    {
                        game.Sound.Run("Woman's_grunt.wav"); 
                    }
                    else
                    {
                        game.Sound.Run("Male's_grunt.wav");
                    }
                    Thread.Sleep(2000);
                    if (game.Bandit.Health <= 0)
                    {
                        break;
                    }
                    game.Bandit.Fight(game.player);
                    if (game.player.Gender == "Female")
                    {
                        game.Sound.Run("Woman's_grunt.wav");
                    }
                    else
                    {
                        game.Sound.Run("Male's_grunt.wav");
                    }

                }
                else if (game.FightInventory[index].GetType().Equals(typeof(Healkungfu))) // jeżeli typu ataku jest równy typowi Heal:
                {
                    game.player.Meditate(); //akcja jeżeli spełnia warunek
                }

                Thread.Sleep(2000); // pauza, aby nie było zbyt "szarpnięte"
                game.Bandit.Fight(game.player); // bandyta uderza player, czyli nas
                if (game.player.Gender == "Male")
                {
                    game.Sound.Run("Male's_grunt.wav");
                }
                else
                {
                    game.Sound.Run("Woman's_grunt.wav");
                }
                Thread.Sleep(2000);
            }
            Clear();
            game.player.DisplayHealthBar();
            game.Bandit.DisplayHealthBar();
            if (game.player.Health <= 0)
            {
                WriteLine("You lose");
                game.Credits.Run();
            }
            else if (game.Bandit.Health <= 0)
            {
                WriteLine("You win!");
            }
            ReadKey(true);
        }
        public void Fighting (Character one, string Technique1, Character two, string Technique2) // metoda walki automatycznej dwóch osób
        {
            game.Sound.syncRun("03 - battle_qiecuo.wav");
            while (one.Health > 0 & two.Health > 0)
            {
                Clear();
                one.DisplayHealthBar();
               
                WriteLine();
                two.DisplayHealthBar();
                one.Fight(two);
                if (two.Gender == "Male")
                {
                    game.Sound.Run("Male's_grunt.wav");
                   
                }
                else
                {
                    game.Sound.Run("Woman's_grunt.wav");
                }
                if (two.Health < 1) // przedwczesna pętla if tego warunku powoduje, że drugi przeciwnik nie będzie "duchem" i mógł mieć możliwości zadawania obrażeń
                {
                    break;
                }
                Thread.Sleep(3000); // czekam 3s = 3000ms aż przeciwnik "uderzy" drugiego, niestety nie wymyśliłem co z wielowątkowością
                two.Fight(one);
                if (one.Gender == "Male")
                {
                    game.Sound.Run("Male's_grunt.wav");
                }
                else
                {
                    game.Sound.Run("Woman's_grunt.wav");
                }
                Thread.Sleep(3000); // czekam 3s = 3000ms aż przeciwnik "uderzy" drugiego
            }
        }
            
    }
}
