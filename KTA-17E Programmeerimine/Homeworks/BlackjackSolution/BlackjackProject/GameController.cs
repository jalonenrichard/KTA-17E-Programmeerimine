using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BlackjackProject
{
    class GameController
    {

        /// <summary>
        /// The card deck currently in play
        /// </summary>
        private List<Card> currentDeckList = new List<Card>();

        /// <summary>
        /// List of all players
        /// </summary>
        private List<Player> playerList = new List<Player>();

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public GameController()
        {

        }

        #endregion

        #region Getters

        /// <summary>
        /// Getter method for list of players
        /// </summary>
        /// <returns>List of players</returns>
        public List<Player> GetPlayerList()
        {
            return playerList;
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Start a new game of Blackjack - shuffle the cards, hand out the first 2 cards to house and player
        /// </summary>
        public void StartNewGame()
        {
            // Shuffle the deck
            ShuffleDeck();
            // Go through the list of all players
            foreach (Player player in playerList)
            {
                // Add first 2 cards from the deck to each players hand
                DealCards(player, 2);
            }
        }

        /// <summary>
        /// Add a player to the list of all players
        /// </summary>
        /// <param name="player">Player object</param>
        public void AddPlayer(Player player)
        {
            playerList.Add(player);
        }

        /// <summary>
        /// Deal 'cards' amount of cards from the deck to 'player'
        /// </summary>
        /// <param name="player">A player from our list of players who we wish to deal cards to</param>
        /// <param name="cards">Amount of cards to deal to that player</param>
        public void DealCards(Player player, int cards)
        {
            // Add int cards amount of cards from the shuffled list to player's hand and remove the cards from the list
            for (int i = 0; i < cards; i++)
            {
                // Add the current card at position i to players hand
                player.cardsInHand.Add(currentDeckList[i]);
                // Add the cards count value to the current value
                player.TotalCount += AssignCardValue(currentDeckList[i]);
                // Remove the card from our Deck
                currentDeckList.RemoveAt(i);
            }
        }

        /// <summary>
        /// Select the winner from the list of players
        /// </summary>
        /// <returns>The winner Player object</returns>
        public Player SelectTheWinner()
        {
            // local variable to compare different players results
            var hihghestScore = 0;
            // return a blank Player when it's a tie
            Player winner = new Player("");

            // Go through each player in the list of players
            foreach (var player in playerList)
            {
                // If the player did not go over 21 and it's higher than the current highest score
                if (player.TotalCount < 22 && player.TotalCount > hihghestScore)
                {
                    // Set the new highscore to that of the current players
                    hihghestScore = player.TotalCount;
                    // And set the player as the winner
                    winner = player;
                } else if (player.TotalCount == hihghestScore)
                {
                    return new Player("");
                }
            }
            return winner;
        }

        /// <summary>
        /// Play the house NPC role automatically
        /// </summary>
        public void PlayHouseCards(Player house)
        {
            // If the value of current cards is 17 or over, stand
            if (house.TotalCount >= 17)
            {
                //Stand
                return;
            }
            // If the value is 16 or under, then hit
            else if (house.TotalCount < 17)
            {
                //Hit
                DealCards(house, 1);
                PlayHouseCards(house);
            }
        }

        #endregion

        #region Private Helpers

        /// <summary>
        /// Shuffle the deck
        /// </summary>
        private void ShuffleDeck()
        {
            // New deck object
            var deck = new Deck();
            // Default deck (unshuffled)
            var deckList = deck.GetDeckList();
            var rnd = new Random();
            // Put all the cards in the unshuffled deck to currentList in a random order
            currentDeckList = deckList.OrderBy(x => rnd.Next()).ToList();
        }

        /// <summary>
        /// Assign a numeric value to each card for future mathematical operations
        /// </summary>
        private int AssignCardValue(Card card)
        {
            switch (card.Type)
            {
                case CardType.Two:
                    return 2;
                case CardType.Three:
                    return 3;
                case CardType.Four:
                    return 4;
                case CardType.Five:
                    return 5;
                case CardType.Six:
                    return 6;
                case CardType.Seven:
                    return 7;
                case CardType.Eight:
                    return 8;
                case CardType.Nine:
                    return 9;
                case CardType.Ace:
                    return 11;
                // Ten, Jack, Queen, King
                default:
                    return 10;
            }
        }

        #endregion
    }
}
