using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

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
        static void Game()
        {
            string tutorial = "\nGoal of the game is to get to or as close to 21 total value, to beat the Jack (dealer), just as in blackjack. \nHowever in this game, there are special rules known as Blacks (how original). \nYou will learn the game as it goes on. best of luck.";
            TypewritingEffect(tutorial, 50);
            string pps = "Press H to hit and S to stay";
            TypewritingEffect(pps, 50);


        } 
        static void gameLogic()
        {
            // 21 x 3.14^x chip sum
            //round = x
            nint y = 1;
            string currentRound = y;
        }
    }

    enum Suit {Spade, Club, Heart, Diamond}
    enum Rank {Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King, Ace}
    class Card 
    {
        public Suit Suit{get; set;}
        public Rank Rank{get; set;}
        public int Value {get; set;}
    }
    class Deck
    {
        
    }
}