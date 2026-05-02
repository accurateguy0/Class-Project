using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Gra_RPG
{
    public class Character
    {
        public string Technique { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        [Range(0, 999)]
        public int MaxHealth { get; set; }

        
        public int Health { get; set; }
        [Range(0, 999)] // atrybut, aby ograniczyc. Atrybuty, są dobre aby przywołać atrybuty postaci, ale wymagają dłuższych kodów od "tradycyjnych" metod więc tak tylko użyję atrybuty
        public int Attack { get; set; } 
        public Character(Game game, string Name, string Gender, int Health, int Attack)
        { 
            this.Name = Name;
            this.Gender = Gender;
            this.MaxHealth = Health;
            this.Health = Health;
            this.Attack = Attack;
        }
        public virtual void Fight(Character other)
        {
            WriteLine("Enemy is fighting!");
        }
        public virtual void TakeDamage(int damage)
        {
            WriteLine("That was a lot of damage!");
        }
        public void DisplayHealthBar()
        {
            Write($"{Name}'s Health: ");
            Write("[");
            BackgroundColor = ConsoleColor.Green;
            if (MaxHealth > 100)
            {
                for (int i = 0; i < Health; i += 10)
                {
                    Write(" ");
                }
                BackgroundColor = ConsoleColor.Black;
                for (int i = Health; i < MaxHealth; i += 10)
                {
                    Write(" ");
                }
            }
            else if (MaxHealth > 20)
            {
                for (int i = 0; i < Health; i+=2)
                {
                    Write(" ");
                }
                BackgroundColor = ConsoleColor.Black;
                for (int i = Health; i < MaxHealth; i+=2)
                {
                    Write(" ");
                }
            }
            else
            {
                for (int i = 0; i < Health; i++)
                {
                    Write(" ");
                }
                BackgroundColor = ConsoleColor.Black;
                for (int i = Health; i < MaxHealth; i++)
                {
                    Write(" ");
                }
            }
                ResetColor();
            Write("]");
            WriteLine($"{Health}/{MaxHealth}");
        }
    }
}
