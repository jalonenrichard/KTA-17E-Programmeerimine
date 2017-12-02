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
        private List<Card> currentList = new List<Card>();

        #region Blackjack Players
        /// <summary>
        /// House/Dealer
        /// </summary>
        public Player house = new Player();

        /// <summary>
        /// Player 1
        /// </summary>
        public Player playerOne = new Player();
        #endregion

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
        /// Getter method for shuffled decklist (for testing)
        /// </summary>
        /// <returns>List of shuffled cards</returns>
        public List<Card> GetCurrentList()
        {
            return currentList;
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

            // Hand out the first 2 cards to each player
            DealFirstTwoCards(house, 2);
            DealFirstTwoCards(playerOne, 2);
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
            currentList = deckList.OrderBy(x => rnd.Next()).ToList();
        }

        /// <summary>
        /// Deal the first 2 cards to house and player
        /// </summary>
        private void DealFirstTwoCards(Player player, int cards)
        {
            // Add int cards amount of cards from the shuffled list to player's hand and remove the cards from the list
            for (int i = 0; i < cards; i++)
            {
                player.AddCardToHand(currentList[i]);
                currentList.RemoveAt(i);
            }
            // And add the card values to TotalCount property of Player object
            player.AddTotalCount();
        }
        #endregion
    }
}
