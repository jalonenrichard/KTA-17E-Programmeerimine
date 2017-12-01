using System;
using System.Collections.Generic;
using System.Linq;

namespace BlackjackProject
{
    class Program
    {
        static void Main(string[] args)
        {

            // -------- TESTS --------
            // Decklist test
            Deck deck = new Deck();
            var deckList = deck.GetDeckList();
            foreach (var card in deckList)
            {
                Console.WriteLine($"{card.Suit} {card.Type} {card.CardValue}");
            }
            Console.WriteLine($"Cards in total: {deckList.Count}");

            Console.WriteLine("----------");

            // Randomized decklist test
            Console.ForegroundColor = ConsoleColor.Green;
            var rnd = new Random();
            var randomizedDecklist = deckList.OrderBy(x => rnd.Next()).ToList();
            foreach (var card in randomizedDecklist)
            {
                Console.WriteLine($"{card.Suit} {card.Type} {card.CardValue}");
            }
            Console.WriteLine($"Cards in total: {randomizedDecklist.Count}");

            Console.ReadKey();
        }

    }
}