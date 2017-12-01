using System;
using System.Collections.Generic;

namespace BlackjackProject
{
    class Program
    {
        static void Main(string[] args)
        {

            // -------- TESTS --------
            Deck deck = new Deck();
            var deckList = deck.GetDeckList();
            foreach (var card in deckList)
            {
                Console.WriteLine($"{card.Suit} {card.Type} {card.CardValue}");
            }
            Console.WriteLine($"Cards in total: {deckList.Count}");
            Console.ReadKey();
        }
    }
}
