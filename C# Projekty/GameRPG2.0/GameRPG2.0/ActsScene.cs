using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;


namespace Gra_RPG
{
    public delegate void Act1Delegate();
    public delegate string DelegateDisplayImage();
    public class ActsScene : Scene
    {
        int index;
        public ActsScene(Game game) : base(game)
        {

        }
        public override void Run()
        {
            Act1Delegate del1 = new Act1Delegate(Act1); // chciałem użyć delegatów dla sportu, ale delegaty chyba ułatwiają widok
            del1(); // można dodać .Invoke, będzie miało podobne zadziałanie. W delegatach jest fajne to, że wywołując jeden delegat można przywołać wiele metod naraz używając techniki konkatenacji(np. del3 = del1 + del2, del1 += metoda2)
            game.Credits.Run();
        }
        public string DisplayYou()
        {
            if(game.player.Gender == "Female")
            {
                return game.ArtAsset.YouFemale.ToString();
            }
            else
            {
                return game.ArtAsset.YouMale.ToString();
            }
        }
        public void Act1()
        {
            DelegateDisplayImage deldisp = new DelegateDisplayImage(DisplayYou);
            AnimateTyping("Orphan from Mt. Shaoshi\r\nOne snowy night, you were abandoned as a baby at the Shaolin Temple Gate. The monks later brought you up. When the Jins united the north, the Shaolin Temple suffered unrest, and you ended up on the streets, hoping to become a famous kung fu practitioner.\r\n");
            ConsoleUtils.WaitForKey();
            Clear();
            AnimateTyping("Once upon a time the war began. \n Territories were ceded, reparations were paid Song was reduced from a once powerful empire to a mere “vassal state.");
            ConsoleUtils.WaitForKey();
            Clear();
            AnimateTyping("Now a decade has passed. The peace between the two states is but a deceiving mirage. On the streets, kungfu sects and gangs are burgeoning out of control…  ");
            ConsoleUtils.WaitForKey();
            Clear();
            AnimateTyping("Thus marking the beginning of your great adventure as a commoner at the crossroad of times…  ");
            ConsoleUtils.WaitForKey();
            Clear();
            AnimateTyping("You have been wandering in this world for quite some time, and you feel like you should do something more. Half a month ago, you heard that, the Beggar Gang was looking for heroes in Xiangyang. You thought that you might join in the fun. Today you find a deserted temple ten miles northwest of Xiangyang, a place to take a break. ");
            ConsoleUtils.WaitForKey();
            Clear();
            game.Sound.syncRun("AtNight.wav");
            WriteLine(deldisp());
            AnimateTyping($"\n{game.player.Name}: It’s getting late. I could use some rest at that deserted temple over there.");
            ConsoleUtils.WaitForKey();
            Clear();
            WriteLine(game.ArtAsset.Temple.ToString());
            AnimateTyping("(You go inside the Temple of Wangyang)");
            ConsoleUtils.WaitForKey();
            Clear();
            WriteLine(deldisp());
            AnimateTyping($"{game.player.Name}: A prayer a day keeps bad luck a day.");
            ConsoleUtils.WaitForKey();
            Clear();
            WriteLine(deldisp());
            AnimateTyping($"{game.player.Name}: An oracle bucket. Draw one.");
            ConsoleUtils.WaitForKey();
            Clear();
            AnimateTyping($"{game.player.Name}: (Clatter…clatter…clatter…)");
            ConsoleUtils.WaitForKey();
            Clear();
            WriteLine(deldisp());
            AnimateTyping($"{game.player.Name}: Here’s goes my fortune told: Serves you right for getting caught at cheating at cards, stripped to the boxers you lousy loser!? Sounds awful!");
            ConsoleUtils.WaitForKey();
            Clear();
            AnimateTyping($"{game.player.Name}: (Check oracle the bucket.)");
            ConsoleUtils.WaitForKey();
            Clear();
            WriteLine(deldisp());
            AnimateTyping($"{game.player.Name}: All the lots speak of ill fortune. Bummer…");
            ConsoleUtils.WaitForKey();
            Clear();
            AnimateTyping($"Mysterious Man: Ha! (Someone is covering their mouth and laughing.)");
            ConsoleUtils.WaitForKey();
            Clear();
            WriteLine(game.ArtAsset.BuddhaStatue);
            AnimateTyping($"{game.player.Name}: Who’s hiding behind Buddha?");
            ConsoleUtils.WaitForKey();
            Clear();
            WriteLine(game.ArtAsset.MysteriousMan);

            AnimateTyping($"Mysterious Man: Take this shitty pauper!");
            ReadKey(true);
            game.Fightscene.Run();
            game.Bandit.Health = game.Bandit.MaxHealth;
            game.Sound.syncRun("06 - huajishijian.wav");
            Clear();
            WriteLine(game.ArtAsset.MysteriousMan);
            AnimateTyping($"Mysterious Man: (he dusts off his robe gently)");
            ConsoleUtils.WaitForKey();
            Clear();
            WriteLine(game.ArtAsset.MysteriousMan);
            AnimateTyping($"Mysterious Man: I thought you were kungfu master hunting me down. Turns out you’re just some hoodlum stepping on toes.");
            ConsoleUtils.WaitForKey();
            Clear();
            WriteLine(deldisp());
            AnimateTyping($"{game.player.Name}: You’re being hunted? What did you do?!");
            ConsoleUtils.WaitForKey();
            Clear();
            WriteLine(game.ArtAsset.MysteriousMan);
            AnimateTyping($"Mysterious Man: That’s a long tale. Not for this occasion. I’d better leave now under the cover of night.");
            ConsoleUtils.WaitForKey();
            Clear();
            WriteLine(deldisp());
            AnimateTyping($"{game.player.Name}: (He’s sneaky. Must be bad sort.)");
            ConsoleUtils.WaitForKey();
            Clear();
            WriteLine(game.ArtAsset.MysteriousMan);
            AnimateTyping($"Mysterious Man: Uh-oh… Someone’s headed this way.");
            ConsoleUtils.WaitForKey();
            Clear();
            WriteLine(game.ArtAsset.MysteriousMan);
            AnimateTyping($"Mysterious Man: Quick, hide!");
            ConsoleUtils.WaitForKey();
            Clear();
            WriteLine(deldisp());
            AnimateTyping($"{game.player.Name}: No room here. Budge over.");
            ConsoleUtils.WaitForKey();
            Clear();
            WriteLine(game.ArtAsset.MysteriousMan);
            AnimateTyping($"Mysterious Man: I can squeeze in. You scoot over…");
            ConsoleUtils.WaitForKey();
            Clear();
            WriteLine(deldisp()); ;
            AnimateTyping($"{game.player.Name}: Hey, that’s my foot…");
            ConsoleUtils.WaitForKey();
            Clear();
            WriteLine(game.ArtAsset.MysteriousMan);
            AnimateTyping($"Mysterious Man: Shush! Quiet! Someone’s here!");
            ConsoleUtils.WaitForKey();
            Clear();
            game.Sound.syncRun("07 - tufashijian.wav");
            WriteLine(game.ArtAsset.Ambercloak);
            AnimateTyping($"Ambercloak: Bastard! I’m taking my revenge. What’s it got to do with you? Why are you always getting in the way!?");
            ConsoleUtils.WaitForKey();
            Clear();
            WriteLine(game.ArtAsset.Ravenhood);
            AnimateTyping($"Ravenhood: Thirty-Six Caverns, Seventy-Two Blessed Lands. More than hundred lives. How can I turn a blind eye to that?");
            ConsoleUtils.WaitForKey();
            Clear();
            WriteLine(game.ArtAsset.Ravenhood);
            AnimateTyping($"Ravenhood: You can settle the score with your foes there-once you get past me!");
            ConsoleUtils.WaitForKey();
            Clear();
            WriteLine(game.ArtAsset.Ambercloak);
            AnimateTyping($"A: Stop bluffing, you old geezer! You couldn’t best me ten years ago. Now that I’ve perfected my skills, I’m going to take you down!");
            ConsoleUtils.WaitForKey();
            Clear();
            WriteLine(game.ArtAsset.Ravenhood);
            AnimateTyping($"R: Enlighten me!");
            ConsoleUtils.WaitForKey();
            Clear();
            game.Ambercloak.Health = game.Ambercloak.MaxHealth;
            game.Ravenhood.Health = game.Ravenhood.MaxHealth;
            game.Fightscene.Fighting(game.Ambercloak, game.Ambercloak.Technique, game.Ravenhood, game.Ravenhood.Technique);
            Clear();
            game.Sound.syncRun("07 - tufashijian.wav");
            ConsoleUtils.WaitForKey();
            WriteLine(game.ArtAsset.Ambercloak);
            AnimateTyping($"A: Our kungfu styles are both from the Taoist Arcane School. We must use the same principles, over and over again. What a drag!");
            ConsoleUtils.WaitForKey();
            Clear();
            WriteLine(game.ArtAsset.Ravenhood);
            AnimateTyping($"R: Your kungfu is based on the Taoist Arcane School. But I fear your haste has led you down the Devil’s path.");
            ConsoleUtils.WaitForKey();
            Clear();
            WriteLine(game.ArtAsset.Ambercloak);
            AnimateTyping($"A: I picked up kungfu by myself. Self-taught, self-trained. How would I know the difference between upright path and the Devil’s path?");
            ConsoleUtils.WaitForKey();
            Clear();
            WriteLine(game.ArtAsset.Ravenhood);
            AnimateTyping($"R: If you train like this, you can barely hold onto your life, let alone seek vengeance…");
            ConsoleUtils.WaitForKey();
            Clear();
            WriteLine(game.ArtAsset.Ambercloak);
            AnimateTyping($"A: …");
            ConsoleUtils.WaitForKey();
            Clear();
            WriteLine(game.ArtAsset.Ravenhood);
            AnimateTyping($"R: I have some Taoist classics here. They can help restrain your thoughts.");
            ConsoleUtils.WaitForKey();
            Clear();
            WriteLine(game.ArtAsset.Ambercloak);
            AnimateTyping($"A: Riding the Wind! Isn’t this the ultimate legendary Taoist kungfu classic!?");
            ConsoleUtils.WaitForKey();
            Clear();
            WriteLine(game.ArtAsset.Ravenhood);
            AnimateTyping($"R: You should not take it!");
            ConsoleUtils.WaitForKey();
            Clear();
            WriteLine(game.ArtAsset.Ambercloak);
            AnimateTyping($"A: Give it to me!");
            ConsoleUtils.WaitForKey();
            Clear();
            AnimateTyping($"(The Ambercloak snatches Riding the Wind.)");
            ConsoleUtils.WaitForKey();
            Clear();
            WriteLine(game.ArtAsset.Ravenhood);
            AnimateTyping($"R: …");
            ConsoleUtils.WaitForKey();
            Clear();
            AnimateTyping($"(Ravenhood and Ambercloak left the Temple )");
            ConsoleUtils.WaitForKey();
            game.Sound.syncRun("AtNight.wav");
            Clear();
            WriteLine(game.ArtAsset.MysteriousMan);
            AnimateTyping($"MM: (The kungfu prowess of these two mavericks is such that I can’t even tell their school or sect… TO think that such masters walk these midland streets…)");
            ConsoleUtils.WaitForKey();
            Clear();
            WriteLine(game.ArtAsset.MysteriousMan);
            AnimateTyping($"MM: Oh? There’s something on the ground…!?");
            ConsoleUtils.WaitForKey();
            Clear();
            WriteLine(game.ArtAsset.MysteriousMan);
            AnimateTyping($"MM: They must have dropped these two kungfu manuals int their scuffle.");
            ConsoleUtils.WaitForKey();
            Clear();
            WriteLine(deldisp());
            AnimateTyping($"{game.player.Name}: What manuals? Don’t even think about hogging them!");
            ConsoleUtils.WaitForKey();
            Clear();
            WriteLine(game.ArtAsset.MysteriousMan);
            AnimateTyping($"MM: I can share. Which one do you want?");
            ConsoleUtils.WaitForKey();
            DisplayTaoistOptions();
            ConsoleUtils.WaitForKey();
            Clear();
            WriteLine(game.ArtAsset.MysteriousMan);
            AnimateTyping($"MM: Now that we both learned some new kungfu, how about a friendly duel?");
            game.NavigationOptions.Add("Inventory");
            game.NavigationOptions.Add("See stats");
            game.NavigationOptions.Add("Interact with Wooden Water Bucket");
            game.NavigationOptions.Add("Interact with Wooden Water Bucket1");
            game.NavigationOptions.Add("Interact with Water Vase");
            game.NavigationOptions.Add("Interact with Broken Vase ");
            game.NavigationOptions.Add("Interact with Merit Box");
            game.NavigationOptions.Add("Interact with Mysterious Man");
            ConsoleUtils.WaitForKey();
            DuelRequest();
            game.Bandit.Health = game.Bandit.MaxHealth;
            Clear();
            game.Sound.syncRun("AtNight.wav");
            WriteLine(game.ArtAsset.MysteriousMan);
            AnimateTyping($"MM: Good job. Let’s call it a day!");
            ConsoleUtils.WaitForKey();
            Clear();
            WriteLine(game.ArtAsset.MysteriousMan);
            AnimateTyping($"MM: Speaking of kungfu, do you know who is the best?");
            ConsoleUtils.WaitForKey();
            Clear();
            deldisp();
            AnimateTyping($"I’ve got no idea. How about you tell me…");
            ConsoleUtils.WaitForKey();
            Clear();
            AnimateTyping($"Before you know it, it’s already late at night… As you get to know each other, you start chatting about sects and gangs, and masters and heroes while you train.");
            ConsoleUtils.WaitForKey();
            Clear();
            AnimateTyping($"While practicing kungfu with you, the mysterious man tells you all about the warriors and hermits of the world. He goes from Shaolin and Beggar Gang to the Four Academies, from Qingcheng and Mt. Heng to the Iron Sand Gang… Prodigy of the East, Savant of the West, Recluse of the North, and Flame of the South!");
            ConsoleUtils.WaitForKey();
            Clear();
            AnimateTyping($"Recluse of the North: Dugu She\r\n4 decades ago, a black-clad swordsman alone triumphed over many northern masters, gaining fame in the Central Plains. His sword disappears to the right and then reappears from the left, sharp and elusive, unmatched by anyone. Often spotted traveling solo in the Northern Desert, he is referred to as the Recluse of the North, having distanced himself from the kungfu scene…\r\n");
            ConsoleUtils.WaitForKey();
            AnimateTyping($"Flame of the South: Dame Yan\r\nOn Mt. Suqin in southern China’s Dali, there is an old Taoist nun in red known as Dame Yan. With her unique skill Flying Fire Finger, she can inflict burning pain on people at a distance with a string or a snap. Although she seldom sets foot on the midland, she is well known in the kungfu world and revered as Dame Yan.\r\n");
            ConsoleUtils.WaitForKey();
            Clear();
            AnimateTyping($"Savant of the West: Jiang Ruijing\r\nThe Langhuan Pavillon in the Western Regions houses a vast collection of kungfu classics, with its Young Master, under 30, well-versed in kung fu of all sects and clans, His Borachio’s Moon Palm is known for its wide reach and ability to crack any moves, The White Python Soft Sword he carries darts through the air like a real snake. People covet Langhuan’s kungfu, seeking favor of its Young Master who is hailed as the Savant of the West.\r\n");
            ConsoleUtils.WaitForKey();
            Clear();
            AnimateTyping($"Prodigy of the East: Lin Fengmian\r\nThe Four Academies of Jiangnan boast a large number of students, with each academy featuring a kungfu faculty led by a kungfu master. Lin Fengmian, Headmaster of Deercave Academy, is the Lin’s family’s second son from Shaoxing, esteemed as the top master in Jiangnan, notably skilled in Qing Kung. Using Wind Swinging Sword, he bested numerous masters and even managed to challenge the Savant of the West,\r\n");
            ConsoleUtils.WaitForKey();
            Clear();
            AnimateTyping($"The Four Greatest Heroes\r\nProdigy of the East, Savant of the West, Recluse of the North and Flame of the South are known as the Four Greatest Heroes,\r\n");
            ConsoleUtils.WaitForKey();
            Clear();
            AnimateTyping($"The mysterious man believes that the kungfu of he two old men who appeared tonight was not inferior to that of the Four Greatest Heroes. Ambercloak’s style is ever-changing, as if multitude of warriors were all attacking at once, leaving no space for a countermove. Yet the stance of Ravenhood is so agile that he is able to quickly fence off all the attacks.");
            ConsoleUtils.WaitForKey();
            Clear();
            AnimateTyping($"In addition to these six masters, there are probably more skilled heroes in the chaotic world. The mysterious man could not help but exclaim, “This world is indeed full of undiscovered talents.” As you two chat and joke, the sky clears…");
            ConsoleUtils.WaitForKey();
            Clear();
            AnimateTyping($"Y: We sparred the whole night and I don’t even know your name.");
            ConsoleUtils.WaitForKey();
            Clear();
            WriteLine(game.ArtAsset.MysteriousMan.ToString());
            AnimateTyping($"MM: We both learned the kungfu of those two mavericks. I guess that makes us fellow disciples.");
            ConsoleUtils.WaitForKey();
            Clear();
            WriteLine(game.ArtAsset.MysteriousMan);
            AnimateTyping($"MM: Looks like I’m older than you are. You can call me brother.");
            ConsoleUtils.WaitForKey();
            Clear();
            string[] options = [">Senior Brother!", ">Pah! You should call me senior brother."];
            Menu menu = new("(How do you call the Mysterious Man?)", options, 0);
            index = menu.Run();
            ConsoleUtils.WaitForKey();
            Clear();
            WriteLine(game.ArtAsset.MysteriousMan);
            AnimateTyping($"MM: Hahaha, I’m heading north now. I left some money at the Black Gale Stronghold in the south. Feel free to take it, if you don’t mind.");
            ConsoleUtils.WaitForKey();
            Clear();
            WriteLine(game.ArtAsset.MysteriousMan);
            AnimateTyping($"MM: Now that you’re trained in kungfu, you can take care of the rogues there for me while you’re at it.");
            ConsoleUtils.WaitForKey();
            Clear();
            game.Inventory.Add(new Item("Black Key", 0));
            WriteLine(game.ArtAsset.BlackKey);
            AnimateTyping($"Obtained Item[Black Key] +1");
            ConsoleUtils.WaitForKey();
            Clear();
            deldisp();
            AnimateTyping($"Y: (Wow… I’m rich!)");
            ConsoleUtils.WaitForKey();
            Clear();
            AnimateTyping($"You go your separate way after bidding each other farewell in the deserted temple…");
            ConsoleUtils.WaitForKey();
        }
        public void DisplayTaoistOptions()
        {
            string prompt = $"(Which kungfu manual do you want to train with?)";
            string[] options = ["\t>Sword Art: Sword on a Platter", "\t>Fist & Palm Art: Fist of the Spirit Fox"];
            Menu menu = new(prompt, options, 0);
            index = menu.Run();
            switch (index)
            {
                case 0:
                    ObtainSword();
                    WriteLine($"Mysterious Man learned [Fist of the Spirit Fox]");
                    game.Bandit.Technique = "Fist of the Spirit Fox";
                    break;
                case 1:
                    ObtainFist();
                    WriteLine($"Mysterious Man learned [Sword on a Platter]");
                    game.Bandit.Technique = "Sword on a Platter";
                    break;
            }
            game.Bandit.Attack += 1;
        }
        public void AnimateTyping(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                game.Sound.Run("textscroll.wav");
                Write(text[i]);
                Thread.Sleep(50);
                if(KeyAvailable) // if user pressed any key
                {
                    ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                    if(keyInfo.Key == ConsoleKey.Enter)
                    {
                        Write(text.Substring(i + 1));
                        break;
                    }
                }
            }
        }
        public void AnimateFrames(string [] frames)
        {
            while (true)
            {
                foreach (string frame in frames)
                {
                    SetCursorPosition(0, 0); // ten kod powoduje ze animacja staje sie bardziej smooth w porównaniu do Clear()
                    WriteLine(frame);
                    Thread.Sleep(100); // przerwa obrazow co 0.1s
                }
            }
        }
        public void ObtainFist()
        {
            WriteLine("Obtained [Fist & Palm Art: Fist of the Spirit Fox] +1");
            game.Inventory.Add(new Fightkungfu("Fist of the Spirit Fox", 3));
            ConsoleUtils.WaitForKey();
        }
        public void ObtainSword()
        {
            WriteLine("Obtained [Sword Art: Sword on a Platter] +1");
            game.Inventory.Add(new Fightkungfu("Sword on a Platter", 3));
            ConsoleUtils.WaitForKey();
        }
        public void DisplayInventory()
        {
            string prompt = $"Your inventory:";
            InventoryMenu Inventorymenu = new InventoryMenu(prompt, game.Inventory);
            index = Inventorymenu.Run();
            
                if(index == 0)
                {
                    DisplayNavigationScene("(What would you want to do?)");
                }
                game.player.Attack += game.Inventory[index].AddStat;
                if(game.Inventory[index].GetType() == typeof(Fightkungfu)) // .GetType() zwraca typ
                {
                    WriteLine($"You learned {game.Inventory[index].Name}!"); 
                    
                    game.FightInventory.Add(game.Inventory[index]);
                    game.Inventory.Remove(game.Inventory[index]);
                    ConsoleUtils.WaitForKey();
                    DisplayInventory();


                }
                else if (game.Inventory[index].GetType() == typeof(Healkungfu))
                {
                    WriteLine($"You learned [{game.Inventory[index].Name}]!");
                    ConsoleUtils.WaitForKey();
                    if (!game.FightInventory.Contains(game.Inventory[index]))
                    {
                        game.FightInventory.Add(game.Inventory[index]);
                        game.Inventory.Remove(game.Inventory[index]);
                    }
                    game.Inventory.Remove(game.Inventory[index]);
                    DisplayInventory();
                }
                else if (game.Inventory[index].GetType() == typeof(Healitem))
                {
                    WriteLine($"You used [{game.Inventory[index].Name}]! +{game.Inventory[index].AddStat}HP");
                    
                    game.player.Health += game.Inventory[index].AddStat;
                    if (game.player.Health > game.player.MaxHealth)
                {
                    game.player.Health = game.player.MaxHealth;
                }
                    game.Inventory.Remove(game.Inventory[index]);
                    ConsoleUtils.WaitForKey();
                    DisplayInventory();
                }
                else if(game.Inventory[index].GetType() == typeof(Item))
                {
                    WriteLine($"This is a/an {game.Inventory[index].Name}");
                    DisplayInventory();
                }
            
            
        }
        public void DisplayStat()
        {
            WriteLine("Your stats:");
            AnimateTyping($"Name: {game.player.Name} ");
            AnimateTyping($"Gender: {game.player.Gender} ");
            AnimateTyping($"HP: {game.player.Health}/{game.player.MaxHealth} ");
            AnimateTyping($"ATK: {game.player.Attack}");
            ConsoleUtils.WaitForKey();
            DisplayNavigationScene("(What would you want to do?)");
        }
        public void DuelRequest()
        {
            
            string prompt = "(Do you want to duel with Mysterious Man?)";
            string []options = [">Duel ", ">Wait"];
            Menu menu = new Menu(prompt, options, 0);
            index = menu.Run();
            switch (index)
            {
                case 0:
                    game.Fightscene.Run();
                    break;
                case 1:
                    prompt = "(What would you want to do?)";
                    
                    DisplayNavigationScene(prompt);
                    break;
            }
        }
        public bool Compare(string option)
        {
            if(game.NavigationOptions[index].Substring(0) == option) // porównuje czy opcję jaką wybraliśmy spełnia ten indeks opcji
            { return true; }
            else
            {
                return false;
            }
        }
        public void DisplayNavigationScene(string prompt)
        {
           
                Clear();
                Predicate<string> comp = new Predicate<string>(Compare); // Predicate to gotowy delegat, a nie custom made, co znacznie skróci tekst i ułatwia widok
                game.Navigation = new NavigationMenu(prompt, game.NavigationOptions);
                index = game.Navigation.Run();
                if (comp.Invoke( "Inventory")) // <= na ten skróciłem z tego: (game.NavigationOptions[index].Substring(0) == "jakiś string"
            {
                    DisplayInventory();
                    DisplayNavigationScene(prompt);

                }
                else if (comp.Invoke("See stats"))
                {
                    DisplayStat();
                }
                else if (comp.Invoke("Interact with Wooden Water Bucket"))
                {
                    WriteLine("You obtained [Honey Cake] +1");
                    game.Inventory.Add(new Healitem("Honey Cake", 5));
                    game.NavigationOptions.Remove(game.NavigationOptions[index]);
                    ReadKey(true);
                    DisplayNavigationScene(prompt);

            }
                else if (comp.Invoke("Interact with Iron Water Bucket")) 
                {
                    WriteLine("You obtained [Cardamon Drink] +1");
                    game.Inventory.Add(new Healitem("Cardamon Drink", 10));
                    game.NavigationOptions.Remove(game.NavigationOptions[index]);
                    ReadKey(true);
                    DisplayNavigationScene(prompt);
                }
                else if (comp.Invoke("Interact with Water Vase")) 
                {
                    WriteLine("You obtained [Dry Wood Drink ] +1");
                    game.Inventory.Add(new Healitem("Dry Wood Drink", 10));
                    game.NavigationOptions.Remove(game.NavigationOptions[index]);
                    ReadKey(true);
                    DisplayNavigationScene(prompt);
                }
                else if (comp.Invoke("Interact with Broken Vase ")) 
                {
                    WriteLine("You obtained 26 Coins");
                    game.NavigationOptions.Remove(game.NavigationOptions[index]);
                    ReadKey(true);
                    DisplayNavigationScene(prompt);
                }
                else if (comp.Invoke("Interact with Merit Box")) 
                {
                    WriteLine("( A merit box for nearby villagers to worship the Buddha and Land Spirits.)");
                    ReadKey(true);
                    DisplayNavigationScene(prompt);
                }
                else if (comp.Invoke("Interact with Mysterious Man")) 
                {
                game.Fightscene.Run();
                }
           
            
            //do
            //    {
            //        switch (index1)
            //        {
            //            case 0:
            //                DisplayInventory();
            //                break;

            //            case 1:
            //                DisplayStat();
            //                break;
            //            case 2:
            //                WriteLine("You obtained [Honey Cake] +1");
            //                game.Inventory.Add(new Fightkungfu("Honey Cake", 5));
            //                game.NavigationOptions.Remove(game.NavigationOptions[index1]);
            //                break;
            //            case 3:
            //                WriteLine("You obtained [Cardamon Drink] +1");
            //                game.Inventory.Add(new Fightkungfu("Cardamon Drink", 10));
            //                break;
            //            case 4:
            //                WriteLine("You obtained [Dry Wood Drink ] +1");
            //                game.Inventory.Add(new Fightkungfu("Dry Wood Drink", 10));
            //                break;
            //            case 5:
            //                WriteLine("You obtained 26 Coins");
            //                break;
            //            case 6:
            //                WriteLine("( A merit box for nearby villagers to worship the Buddha and Land Spirits.)");
            //                break;
            //            case 7:
            //                DuelRequest();
            //                break;

            //        }

            //    } while (index1 != 7);
        }
    }
}
