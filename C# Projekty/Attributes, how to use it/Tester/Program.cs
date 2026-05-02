using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Tester
{
    public class StatsAttribute : Attribute
    {
        public string Nameattr { get; }
        public int Healthattr { get; }

        public StatsAttribute(string nameattr, int healthattr)
        {
            Nameattr = nameattr;
            Healthattr = healthattr;
        }
    }

    // 2. Apply the attribute to a game class (e.g., a player or enemy class)
    [Stats("Player", 100)]
    public class Character
    {
        public string Name { get; private set; }
        public int Health { get; private set; }

        public Character(string name, int health)
        {
            Name = name;
            Health = health;
        }

        public void TakeDamage(int amount)
        {
            Health -= amount;
            Console.WriteLine($"{Name} took {amount} damage. Health: {Health}");
        }
    }

    // 3. Runtime logic to discover and process entities using reflection
    public class StatChange
    {
        public void DisplayStats()
        {
            Assembly assembly = Assembly.GetExecutingAssembly(); // Or a specific game assembly

            foreach (Type type in assembly.GetTypes())
            {
                // Try to get the custom GameEntityAttribute from the type
                StatsAttribute stat = type.GetCustomAttribute<StatsAttribute>();

                if (stat != null)
                {
                    Console.WriteLine($"    Who: {type.Name}");
                    Console.WriteLine($"    Name: {stat.Nameattr}");
                    Console.WriteLine($"    Health: {stat.Healthattr}");

                    // Example: Instantiate the entity and add it to the game world
                    // Note: For actual game objects, a factory or engine-specific instantiation would likely be used
                    if (type == typeof(Character))
                    {
                        Character player = (Character)Activator.CreateInstance(type, stat.Nameattr, stat.Healthattr); // zamiast użyć new PlayerCharacter(...), Activator.CreateInstance pozwala ci na tworzeniu obiektu znając tylko obiekt System.Type ( w tym przypadku type), która pozwala na dynamiczne tworzenie obiektów. Activator.CreateInstance wyszukuje parametry konstruktora która pasuje do typów i koelejności argumentu.
                        Console.WriteLine($"    Instantiated {player.Name} with {player.Health} health.");
                        player.TakeDamage(10); // Simulate some action
                    }
                }
            }
           
        }
    }

    // Example Main method to run this
    public class Program
    {
        public static void Main(string[] args)
        {
            StatChange modiattr = new StatChange();
            modiattr.DisplayStats();
            ReadKey();
        }
    }
}
