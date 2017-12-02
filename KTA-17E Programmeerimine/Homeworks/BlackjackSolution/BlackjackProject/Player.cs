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

        #region Constructor
        /// <summary>
        /// Default constructor
        /// </summary>
        public Player()
        {

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
        #endregion
    }
}
