using System;
using System.Collections.Generic;
using System.Linq;

namespace BlackjackProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Player playerOne = new Player("Richard");
            Player playerTwo = new Player("Jaak");
            Player playerThree = new Player("Peeter");
            Player playerFour = new Player("Pakiraam");
            GameController gameController = new GameController();
            gameController.AddPlayer(playerOne);
            gameController.AddPlayer(playerTwo);
            gameController.AddPlayer(playerThree);
            gameController.AddPlayer(playerFour);
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
            gameController.StartNewGame();
            var randomizedDecklist = gameController.GetCurrentList();
            foreach (var card in randomizedDecklist)
            {
                Console.WriteLine($"{card.Suit} {card.Type} {card.CardValue}");
            }
            Console.WriteLine($"Cards in total: {randomizedDecklist.Count}");

            // House hand test
            TestPlayerHands(gameController.house);

            // Player 1 hand test
            TestPlayerHands(playerOne);
            // Player 2 hand test
            TestPlayerHands(playerTwo);
            // Player 3 hand test
            TestPlayerHands(playerThree);
            // Player 4 hand test
            TestPlayerHands(playerFour);

            Console.ReadKey();
        }


        private static Random _random = new Random();
        /// <summary>
        /// Create a random console color to use in each player's display text
        /// </summary>
        /// <returns>random ConsoleColor Enum value</returns>
        private static ConsoleColor GetRandomConsoleColor()
        {
            var consoleColors = Enum.GetValues(typeof(ConsoleColor));
            var randomColor = (ConsoleColor)consoleColors.GetValue(_random.Next(consoleColors.Length));
            if (randomColor == ConsoleColor.Black)
            {
                GetRandomConsoleColor();
            }
            return randomColor;
        }

        /// <summary>
        /// Test method for each player
        /// </summary>
        /// <param name="player">each individual player object</param>
        private static void TestPlayerHands(Player player)
        {
            Console.ForegroundColor = GetRandomConsoleColor();
            Console.WriteLine("----------");
            Console.WriteLine($"Player: {player.PlayerName}");
            var playerHand = player.GetPlayerHand();
            foreach (var card in playerHand)
            {
                Console.WriteLine($"{card.Suit} {card.Type} {card.CardValue}");
            }
            Console.WriteLine($"Sum of card values: {player.TotalCount}");
            Console.WriteLine($"Cards in hand: {playerHand.Count}");
        }

    }
}