using System;
using System.IO;

namespace Jackblack {
    class Program {
        static void Main(String[]args)
        {
            Console.Title = "Jackintheblack 21";
            Console.Clear();

            String text = File.ReadAllText("asciiartJITB.txt");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(text);
            Console.ReadKey(true);
        }
        static void Game(String[]args)
        {

        } 
    }
    class Card {
        public string Suit {get; set;}
        public string Rank {get; set;}
        public int Value {get; set;}
    }
}