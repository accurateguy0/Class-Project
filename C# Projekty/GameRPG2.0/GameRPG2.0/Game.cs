using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Gra_RPG
{
    public class Game // Ta klasa łączy wszystkie pozostałe klasy ze sobą, to nie jest optymalny sposób, ale to pattern wystarczalny na ten projekt
    {
        public CharacterCreationScene CharacterCreation;
        public TitleScene Title;
        public ActsScene Act1;
        public FightScene Fightscene;
        public CreditsScene Credits;
        public Player player;
        public Enemy Bandit;
        public Enemy Ambercloak;
        public Enemy Ravenhood;
        public Soundtrack Sound;
        public string inputname;
        public string inputgender;
        public List<Kungfu> Inventory;
        public List<string> NavigationOptions;
        public InventoryMenu Inventorymenu;
        public NavigationMenu Navigation;
        public List<Kungfu> FightInventory; // klasa specjalna List to tabela, która rozszerza swój wymiar ze względu na ilość elementów w przeciwieństwie do Array, w której musiałeś/aś definiować/deklarować/stworzyć jej wartość wymiaru na początku instancji/tworzenia
        public ArtAsset ArtAsset;
        public FightMenu Fightmenu;
        public Game() 
        {
            Console.Title = "RPG Game";
            CharacterCreation = new CharacterCreationScene(this);
            Title = new TitleScene(this);
            Credits = new CreditsScene(this); // słowo kluczowe "this" referuje się do "tej" klasy Game
            Fightscene = new FightScene(this);
            Act1 = new ActsScene(this);
            Credits = new CreditsScene(this);
            Bandit = new Enemy(this, "Mysterious Man", "Male", 10, 2)
            { Technique = "Judge Double Brushes"};

            Ravenhood = new Enemy(this, "Ravenhood", "Male", 400, 135)
            {
                Technique = "Plum Blossom Hand"
            };
            Ambercloak = new Enemy(this, "Ambercloak", "Male", 300, 140);
            Ambercloak.Technique = "Hail of Pear Blossom";
            Sound = new Soundtrack();
            Inventory = new List<Kungfu>();
            NavigationOptions = new List<string>();
            FightInventory = new List<Kungfu>();
            Fightmenu = new FightMenu(this, $"What's your move?:", FightInventory);
            ArtAsset = new ArtAsset();
        }
        public void Start()
        {
            FightInventory.Clear();
            Inventory.Clear();
            NavigationOptions.Clear(); // usuwam wszystko w tabeli NAvigationOptions co miałem do tej pory, aby gra była "odnawialna" używając słowa kluczowego "Clear"
            player = new Player(this, inputname, inputgender, 5, 1);
            player.Gender = "Male";
            FightInventory.Add(new Healkungfu("Meditate", 1));
            FightInventory.Add(new Fightkungfu("Rushing Finger", 9));
            Inventory.Add(new Kungfu("Exit", 0));
            Title.Run();
            
        }
    }
}
