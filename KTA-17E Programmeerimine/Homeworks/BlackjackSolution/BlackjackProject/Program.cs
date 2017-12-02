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
            var gameController = new GameController();
            gameController.StartNewGame();
            var randomizedDecklist = gameController.GetCurrentList();
            foreach (var card in randomizedDecklist)
            {
                Console.WriteLine($"{card.Suit} {card.Type} {card.CardValue}");
            }
            Console.WriteLine($"Cards in total: {randomizedDecklist.Count}");

            Console.WriteLine("----------");
            
            // House hand test
            Console.ForegroundColor = ConsoleColor.Cyan;
            var houseHand = gameController.house.GetPlayerHand();
            foreach (var card in houseHand)
            {
                Console.WriteLine($"{card.Suit} {card.Type} {card.CardValue}");
            }
            Console.WriteLine($"Cards in total: {houseHand.Count}");

            Console.WriteLine("----------");

            // Player 1 hand test
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            var playerOneHand = gameController.playerOne.GetPlayerHand();
            foreach (var card in playerOneHand)
            {
                Console.WriteLine($"{card.Suit} {card.Type} {card.CardValue}");
            }
            Console.WriteLine($"Cards in total: {playerOneHand.Count}");

            Console.ReadKey();
        }

    }
}