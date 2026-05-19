using System;
using System.IO;
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

            String title = File.ReadAllText("asciiartJITB.txt");
            Console.ForegroundColor = ConsoleColor.Blue;
            TypewritingEffect(title, 15);
            Console.WriteLine("Press 'Y' to play.");
            ConsoleKeyInfo input = Console.ReadKey(true);

            if (input.Key == ConsoleKey.Y)
            {
                Game();
            }
        }
        static void Game()
        {
            string tutorial = "Goal of the game is to get to or as close to 21 total value, to beat the Jack (dealer), just as in blackjack. \nHowever in this game, there are special rules known as Blacks (how original). \nYou will learn the game as it goes on. best of luck.";
            //Jack has Split personality disorder = these are the jokers of this game they are called jesters.
            //Im thinking that 21 is arbitrary, you get chips and the value that you get is the chips and the mult is based on the blacks IE pocket ACE or Black jacks (double jack thats a dark suit like spade or club)
            //if you get a Blackjack (two jacks) you automatically get chips X ((11x2) + base mult of jacks wich is 11) a Black is kind of a synergy. you do not get this if you use a spade and a heart jack you only get 11 mult
            //pocket ace has a base mult of 21 while adding the ace value on top of it: 21 + (15 x 2). ace has 2 values, 1 chosen before each run. 
            //sepcial events are hardcoded into the dealer, depending on the personality of the dealer and the "ante"
            //Round starts, chip target shown
            //Player builds hand, scores chips × mult
            //Hit target = survive, miss = run over
            //Beat dealer = bonus blind effect triggers (good or bad depending on outcome)
            //Chip target scales exponentially each round
            //Jesters modify scoring throughout
            //Special events like Dealer's Rage shake up the run
            TypewritingEffect(tutorial, 50);
        } 
    }
    class Card {
        public string Suit {get; set;}
        public string Rank {get; set;}
        public int Value {get; set;}
    }
}