using System;
using System.Collections.Generic;
using System.Text;

namespace BlackjackProject
{
    #region Enums for every possible Card
    /// <summary>
    /// All possible card types
    /// </summary>
    public enum CardType
    {
        Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King, Ace
    }

    /// <summary>
    /// All possible card suits
    /// </summary>
    public enum CardSuit
    {
        Spades, Hearts, Diamonds, Clubs
    }
    #endregion

    class Card
    {
        #region Public Properties
        /// <summary>
        /// Suit of the card
        /// </summary>
        public CardSuit Suit { get; }

        /// <summary>
        /// Card number or jack, queen, king, ace
        /// </summary>
        public CardType Type { get; }
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="suit">Suit of the card</param>
        /// <param name="type">Number/type of the card (2 to ace)</param>
        public Card(CardSuit suit, CardType type)
        {
            this.Suit = suit;
            this.Type = type;
        }
        #endregion

    }
}
