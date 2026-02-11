using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_4_Dawid
{
   
        public class OnePart
        {
            public OnePart Head;
            public OnePart NewPart;
            OnePart Pomocniczy;
            public OnePart NextPart;
        public void DeleteBeginning(string x)
            {
                if (Head.Value == x)
                {
                    Pomocniczy = Head.NextPart;
                    Head = null;//Usuwanie z pamięci!!!
                    Head = Pomocniczy;
                }
            }


            public void Add(string x) // dodawanie na poczatku listy
            {
                NewPart = new OnePart(x);
                NewPart.NextPart = Head;
                Head = NewPart;
            }
            public string Value;
                
                public OnePart(string x)
                {
                    Value = x; //Zapamiętanie
                    NextPart = null; //Wskaźnik = null
                }//Koniec konstruktora
                public void Write(string x)  //Metoda do dopisania w klasie OnePart, dodawanie na koncu listy
                {
                    if (NextPart == null)
                    {
                        NextPart = new OnePart(x);
                    }
                    else
                    {
                        NextPart.Write(x);
                    }
                }//Koniec metody

                public bool Search(string x) //wyszukiwanie elementu w liście
                {
                    bool score;
                    score = false; //Domyślna wartość!
                    if (Value == x) score = true;
                    if ((score == false) && (NextPart != null))
                    {
                        score = NextPart.Search(x);
                    }
                    return score;
                }//koniec metody

                public OnePart getNextPart()
                {
                    return NextPart;
                }//Koniec pobierania referencji do następnego elementu

                public String getString()
                {
                    return Value;
                }

                public void DeleteEnd(string x) // usuwanie elementu na koncu listy
                {
                    if (NextPart != null)
                    {
                        if (NextPart.Value == x)
                        {
                            if (NextPart.NextPart == null)
                            {
                                NextPart = null;
                            }
                        }
                    }
                }

                //Metoda rekurencyjna w klasie ElementListy
                public void DeleteAll()
                {
                    if (NextPart != null)
                    {
                        if (NextPart.NextPart != null)
                        {
                            NextPart.DeleteAll();
                        }
                        NextPart = null;
                    }//end if
                }//koniec metody

                public void Show()
                {
                    Console.WriteLine(Value);

                    if (NextPart != null)
                    {
                        NextPart.Show();
                    }
                    else
                    {
                        Console.WriteLine(" ");
                    }//end if

                }//Koniec metody pokaż

        }


        
    

    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Napisz wartosc dla listy jednokierunkowej");
            string text = Console.ReadLine(); 
            OnePart part = new OnePart(text);
            part.Head = null;
            do
            {
                text = Console.ReadLine();
                Console.WriteLine(part.Head == null);
                if (part.Head == null)
                {
                    part.Head = new OnePart(text);
                }
                else
                {
                    part.Head.Add(text);
                }
            } while (text.CompareTo("end") != 0);
            part.Head.Show();
            Console.WriteLine(part.Head.NextPart);
            Console.ReadKey();
        }

    }
}



