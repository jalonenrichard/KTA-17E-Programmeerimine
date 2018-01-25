using System;
using System.Collections.Generic;
using System.Linq;

namespace BlackjackProject
{
    class Program
    {
        // Create a new GameController object
        static GameController gameController = new GameController();

        static void Main(string[] args)
        {
            // Inform the user about what this program is about
            Console.WriteLine("Welcome to the game of Blackjack!\n");

            // Add our players (House and Player in this assignment)
            House house = new House("House");
            Player playerOne = new Player("Player One");
            gameController.AddPlayer(house);
            gameController.AddPlayer(playerOne);

            // Start new game (shuffle the deck, deal first 2 cards to each player)
            gameController.StartNewGame();

            Console.WriteLine("----------");

            // Print the house hand to the user (only showing 1 card)
            PrintPlayersHand(house);
            // Print the players hand to the user
            PrintPlayersHand(playerOne);
            Console.WriteLine("----------");

            // Ask the player what to do next (1 to hit or 2 to stand)
            HitOrStand(playerOne);
            Console.WriteLine("----------");

            // Hit or Stand for House (Automatically decides if he hits or stands)
            gameController.PlayHouseCards(house);

            // Reveal the end results to the user
            RevealResults();

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }


        #region Helper Methods

        /// <summary>
        /// Print method for each players hand
        /// </summary>
        /// <param name="player">each individual Player object</param>
        private static void PrintPlayersHand(Player player)
        {
            // Inform the user about the name of given player
            Console.WriteLine($"Player: {player.PlayerName} - has been dealt: ");

            // Get the players hand List
            var playerHand = player.GetPlayerHand();
            // If it is house then we don't want to show other cards than the first one
            if (player.IsHouse)
            {
                // Go through the hand of our House player
                for (int i = 0; i < playerHand.Count; i++)
                {
                    // If it is NOT the first card, then do not show the card
                    if (i != 0)
                    {
                        Console.WriteLine("[?]");
                    }
                    // If it is the first card, show it as usual
                    else
                    {
                        Console.WriteLine($"{playerHand[0].Type} {playerHand[0].Suit}");
                    }
                }
                Console.WriteLine();
            }
            // Other players (NON-House)
            else
            {
                // Go through the given players hand
                foreach (var card in playerHand)
                {
                    // Inform the player about the cards in hand
                    Console.WriteLine($"{card.Type} {card.Suit}");
                }
                // Inform the user about the total count of their cards by Blackjack rules
                Console.WriteLine($"Sum of card values: {player.TotalCount}");
            }
        }

        /// <summary>
        /// Ask the player if they want to continue playing or stand
        /// </summary>
        /// <param name="player">Current player</param>
        private static void HitOrStand(Player player)
        {
            // End the game without asking if the user is already over 21
            if (player.TotalCount > 21)
            {
                Console.WriteLine("\n ---- Over 21 ----");
                Console.WriteLine("\n Press any key to continue");
                Console.ReadKey();
                return;
            }

            // Otherwise ask the user what they want to do next
            Console.WriteLine("\nWould you like to hit or stand?");
            Console.WriteLine("Type 1 - to hit (take another card)");
            Console.WriteLine("Type 2 - to stand (to finish)");
            Console.Write("I choose: ");
            string choice = Console.ReadLine().Trim();
            Console.WriteLine();
            // If user chose 1
            if (choice == "1")
            {
                // Let the gameController deal another card to that player
                gameController.DealCards(player, 1);
                // Show the new hand to the player
                PrintPlayersHand(player);
                // And ask again
                HitOrStand(player);
            } 
            // Finish the game
            else if (choice == "2")
            {
                return;
            }
            // Invalid input (not 1 or 2)
            else
            {
                Console.WriteLine($"{choice} is not a valid input, try again");
                // Ask again
                HitOrStand(player);
            }
            
        }

        /// <summary>
        /// Reveal the end results of the game (all hands and Values and winner)
        /// </summary>
        private static void RevealResults()
        {
            // Get the list of all players in current game
            var playerList = gameController.GetPlayerList();
            // Go through the list of players
            foreach (var player in playerList)
            {
                // Print the name of that player 
                Console.WriteLine($"\n{player.PlayerName} had : ");
                // And go through that players hand
                foreach (var card in player.GetPlayerHand())
                {
                    // And Print each card in the hand
                    Console.WriteLine($"{card.Type} {card.Suit}");
                }
                // Finally show the total value of the players cards according to blackjack rules
                Console.WriteLine($"Sum of card values: {player.TotalCount}");
            }
            // Pick the winner
            Player winner = gameController.SelectTheWinner();
            // SelectTheWinner returns a blank player with a blank name when it's a tie
            if (winner.PlayerName == "" || winner.PlayerName == null)
            {
                Console.WriteLine("\nIt's a tie");
            }
            // If it's not a tie
            else
            {
                // Announce the winner
                Console.WriteLine($"\n{gameController.SelectTheWinner().PlayerName} wins");
            }
        }

        #endregion
    }
}