using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Gra_RPG
{
    public class Enemy: Character
    {
       


        public Enemy(Game game, string Name, string Gender, int Health, int Attack) : base(game, Name, Gender, Health, Attack)
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
            WriteLine($"{Name} attacks {other.Name} with {Technique} and deals {Attack} damage!");
            ResetColor();
        }
        public override void TakeDamage(int damage)
        {
            Health -= damage;
            if (Health < 0)
            {
                Health = 0;
            }
        }
       
    }
}
