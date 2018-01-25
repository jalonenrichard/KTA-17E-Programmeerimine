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
        public List<Card> cardsInHand = new List<Card>();

        #region Properties
        /// <summary>
        /// Name of the player
        /// </summary>
        public string PlayerName { get; private set; }

        /// <summary>
        /// Sum of cards by Blackjack rules
        /// </summary>
        public int TotalCount { get; set; }
        
        /// <summary>
        /// House player identifier
        /// </summary>
        public bool IsHouse { get; protected set; }
        #endregion

        #region Constructor
        /// <summary>
        /// Default constructor
        /// </summary>
        public Player(string name)
        {
            // Assign the name of given player
            PlayerName = name;
            // Not a house player, House has its own class
            IsHouse = false;
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

    }
}