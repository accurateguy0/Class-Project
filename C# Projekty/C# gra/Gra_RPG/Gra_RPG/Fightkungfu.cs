using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra_RPG
{
    public class Kungfu
    {
        public string Name;
        public int AddStat;
        public Game game;
        public Kungfu(string Name, int AddStat)
        {
            this.Name = Name;
            this.AddStat = AddStat;
        }
       
    }
    public class Fightkungfu : Kungfu
    {
        public Fightkungfu(string Name, int AddAttack):base(Name, AddAttack) 
        {
            this.Name = Name;
            this.AddStat = AddAttack;
        }
    }
    public class Healkungfu : Kungfu
    {
        public Healkungfu(string Name, int Heal):base(Name, Heal)
        {
            this.Name = Name;
            AddStat = Heal;
        }
    }
    public class Healitem : Kungfu
    {
        public Healitem(string Name, int Heal) : base(Name, Heal)
        {
            this.Name = Name;
            AddStat = Heal;
        }
    }
    public class Item : Kungfu // dzielę je na podklasy, aby je później odróżnić w Inventory i jakie będzie miało zachowanie po "aktywacji"
    {
        public Item(string Name, int index) : base(Name, index)
        {
            this.Name = Name;
            AddStat = index;
        }
    }
}
