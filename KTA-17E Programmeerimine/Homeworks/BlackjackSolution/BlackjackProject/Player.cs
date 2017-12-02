using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BlackjackProject
{
    class Player
    {
        /// <summary>
        /// List to store Players cards currently in hand
        /// </summary>
        private List<Card> cardsInHand = new List<Card>();

        #region Properties
        public string PlayerName { get; private set; }

        /// <summary>
        /// Sum of cards by Blackjack rules
        /// </summary>
        public int TotalCount { get; private set; }
        #endregion

        #region Constructor
        /// <summary>
        /// Default constructor
        /// </summary>
        public Player(string name)
        {
            PlayerName = name;
        }
        #endregion

        #region Getters
        /// <summary>
        /// Getter method for the list of cards currently in players hand
        /// </summary>
        /// <returns></returns>
        public List<Card> GetPlayerHand()
        {
            return cardsInHand;
        }
        #endregion

        #region Public Methods

        /// <summary>
        /// Method to add cards to current hand
        /// </summary>
        /// <param name="card">The card that GameController dealt</param>
        public void AddCardToHand(Card card)
        {
            cardsInHand.Add(card);
        }

        /// <summary>
        /// Add the values of each card to the TotalCount property
        /// </summary>
        public void AddTotalCount()
        {
            // If the list is not empty
            if (cardsInHand.Count != 0)
            {
                // Go through the list and add the card values
                foreach (Card card in cardsInHand)
                {
                    TotalCount += card.CardValue;
                }
            }
        }

        #endregion
    }
}