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

        /// <summary>
        /// Numeric value of the card in blackjack
        /// </summary>
        public int CardValue { get; private set; }
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
            AssignCardValue();
        }
        #endregion

        #region Private Helpers
        /// <summary>
        /// Assign a numeric value to each card for future mathematical operations
        /// </summary>
        private void AssignCardValue()
        {
            switch (Type)
            {
                case CardType.Two:
                    CardValue = 2;
                    break;
                case CardType.Three:
                    CardValue = 3;
                    break;
                case CardType.Four:
                    CardValue = 4;
                    break;
                case CardType.Five:
                    CardValue = 5;
                    break;
                case CardType.Six:
                    CardValue = 6;
                    break;
                case CardType.Seven:
                    CardValue = 7;
                    break;
                case CardType.Eight:
                    CardValue = 8;
                    break;
                case CardType.Nine:
                    CardValue = 9;
                    break;
                case CardType.Ace:
                    CardValue = 11;
                    break;
                // Ten, Jack, Queen, King
                default:
                    CardValue = 10;
                    break;
            }
        }
        #endregion
    }
}
