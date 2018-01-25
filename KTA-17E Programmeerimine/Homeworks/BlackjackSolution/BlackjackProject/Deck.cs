using System;
using System.Collections.Generic;
using System.Text;

namespace BlackjackProject
{
    class Deck
    {
        /// <summary>
        /// List of all the cards in the pack
        /// </summary>
        private List<Card> DeckList = new List<Card>();

        #region Constructor
        /// <summary>
        /// Default constructor
        /// </summary>
        public Deck()
        {
            CreateDeck();
        }
        #endregion

        #region Getters
        /// <summary>
        /// Getter method for DeckList containing all the cards in the playing deck
        /// </summary>
        /// <returns>Default deck of cards 2 to Ace</returns>
        public List<Card> GetDeckList()
        {
            return DeckList;
        }
        #endregion

        #region Private Helpers
        /// <summary>
        /// Fill the deck with Card objects
        /// </summary>
        private void CreateDeck()
        {
            // go through each Suit
            for (int i = 0; i < Enum.GetNames(typeof(CardSuit)).Length; i++)
            {
                // and go through each type/number (2 to ace)
                for (int j = 0; j < Enum.GetNames(typeof(CardType)).Length; j++)
                {
                    // and fill the deck with the cards with Suit i and Type j
                    DeckList.Add(new Card((CardSuit)i, (CardType)j));
                }
            }
        }
        #endregion
    }
}
