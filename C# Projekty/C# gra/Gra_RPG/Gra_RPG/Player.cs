using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Gra_RPG
{
    public class Player : Character
    {
        public int SkillPoints{ get; set;}

        public Player(Game game, string Name, string Gender, int Health, int Attack):base(game, Name, Gender, Health, Attack)
        {
            this.Name = Name;
            this.Gender = Gender;
            this.Health = Health;
            this.Attack = Attack;
            MaxHealth = Health;

        }
        public override void Fight(Character other)
        {
            ForegroundColor = ConsoleColor.Red;
            other.TakeDamage(Attack);
            WriteLine($"{Name} attacks with {Technique} and deals {other.Name} {Attack} damage!");
            ResetColor();
        }
        public override void TakeDamage(int damage)
        {
            Health -= damage;
            if (Health < 0) // zapobiega zdrowiu spadnięcia poniżej zera
            {
                Health = 0;
            }
        }
        public void Meditate()
        {
            if (Health < MaxHealth) 
            {
                Health += 1;
            }
            WriteLine("You're meditating.. you feel the surge of energy in your body");
        }
    }
}
