using System;
using System.IO;
//Don't know why it imports system IO and sometimes system[numbers]
//but i think it has to do with the game being in the terminal.
//gonna try to remake it with python later.

namespace Jackblack {
    class Program {
        static void TypewritingEffect(string text, int delayMilliseconds)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(delayMilliseconds);
            }
            Console.WriteLine();
        } 
        //this main void is what the users see, it calls on the game for the gamelogic so that the user can play it, 
        //plan is to only make this a blackjack game
        static void Main(String[]args)
        {
            Console.Title = "Jackintheblack 21";
            Console.Clear();

            string title = File.ReadAllText("asciiartJITB.txt");
            TypewritingEffect(title, 15);
            Console.WriteLine("\nPress Y to start or N to close.");
            ConsoleKeyInfo input = Console.ReadKey(true);

            if (input.Key == ConsoleKey.Y)
            {
                Game();
            } 
            else if (input.Key == ConsoleKey.N)
            {
                Random rand = new Random();
                string[] byetext = {
                    "Alas, good patrons! The curtain falls, the bells must jingle elsewhere, and I must take my leave. Huzzah!", 
                    "For my final act, I shall vanish into the night—without paying the royal tab! Curtsies dramatically", 
                    "Thus concludes tonight's comedy special. Be kind to the juggler, and never forget the fool!", 
                    "I bid thee farewell! May your pillows always be warm, and your jesters slightly less insulting than I was.", 
                    "I'm off! I'd tell you to miss me, but a fool's absence is usually a blessing. Jingle, jingle!",
                    "Farewell! I leave you now to go find someone who actually cares about your ridiculous demands.",
                    "Jest keep smiling, I'm off!",
                    "To jest or not to jest? I'm out!",
                    "The king demands my presence or at least my taxes. Tally-ho!",
                    "Let the good times jest! I'll be back when you least expect it.",
                    "Farewell! A fool and their sanity are soon parted, so I am leaving before I lose mine entirely.",
                    "To the exit! If anyone asks, I was brilliant and entirely well-behaved."
                    };
                int randomIndex = rand.Next(byetext.Length);
                string randomWord = byetext[randomIndex];
                string exitkey = "Press any key to exit";

                //this randomizes the goodbye message - reminds me of skeletor

                TypewritingEffect(randomWord, 15);
                TypewritingEffect(exitkey, 15);
                Console.ReadKey(true);
                Environment.Exit(0);
            }
        }
        //This is the start of the game void, this is all of the logic that the game uses
        static void Game()
        {
            string tutorial = "\nGoal of the game is to get to or as close to 21 total value, to beat the Jack (dealer), just as in blackjack. \nHowever in this game, there are special rules known as Blacks (how original). \nYou will learn the game as it goes on. best of luck.";
            TypewritingEffect(tutorial, 50);
            string pps = "Press H to hit and S to stay";
            TypewritingEffect(pps, 50);

            //This isnt a uneeded defining of value, the While will break as far as i know.
            int aceValue = 0;
            bool isValidInput = false;

            while (!isValidInput)
            {
                string askforACE = "For this run, is Ace 1 or 11?";
                TypewritingEffect(askforACE, 50);
                string aceinput = Console.ReadLine();
                if (aceinput == "1")
                {
                    string aceinputtext = "Ace = 1";
                    TypewritingEffect(aceinputtext, 15);
                    aceValue = 1;
                    isValidInput = true;
                }
                else if (aceinput == "11")
                {
                    string aceinputtext2 = "Ace = 11";
                    TypewritingEffect(aceinputtext2, 15);
                    aceValue = 11;
                    isValidInput = true;
                }
                else
                {
                    string notaccepted = "The thing you entered is not allowed";
                    TypewritingEffect(notaccepted, 15);
                    isValidInput = false;
                }


            }

        } 

    //these define the cardtypes, ace is ambigous, jack queen and king are all ten
    public enum Suit {Spade, Club, Heart, Diamond}
    public enum Rank {Two=2, Three=3, Four=4, Five=5, Six=6, Seven=7, Eight=8, Nine=9, Ten=10, Jack, Queen, King, Ace}
    public class Card 
    {
        public Suit Suit{get; set;}
        public Rank Rank{get; set;}
    }
    //this defines the deck, wiht the deck, defining the ace as when the ace is chosen in game logic
    //and deck shuffling
    class Deck
    {
        private List<Card> cards = new List<Card>();
        public Deck()
        {
            foreach (Suit suit in Enum.GetValues<Suit>())
            {
                foreach (Rank rank in Enum.GetValues<Rank>())
                {
                    cards.Add(new Card
                    {
                        Suit = suit,
                        Rank = rank,
                    });
                }
            }
        }

        public static int GetValue(Rank rank, int aceValue)
        {
            if (rank == Rank.Ace) return aceValue;
            if (rank >= Rank.Jack) return 10;
            return (int)rank;
        }

        public void Shuffle()
        {
                
        }

    }
        
    }
}