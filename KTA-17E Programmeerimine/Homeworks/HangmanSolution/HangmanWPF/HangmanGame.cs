using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanWPF
{
    class HangmanGame
    {
        #region public properties

        /// <summary>
        /// Total number of guesses
        /// </summary>
        public int NumberOfGuesses { get; private set; }

        /// <summary>
        /// Total number of mistakes
        /// </summary>
        public int MistakeCounter { get; private set; }

        /// <summary>
        /// Word the user is trying to guess
        /// </summary>
        public string WordToGuess { get; private set; }

        /// <summary>
        /// Characters the user has guessed
        /// </summary>
        private List<char> CharactersGuessed { get; set; }

        #endregion

        /// <summary>
        /// Default Constructor
        /// </summary>
        public HangmanGame()
        {
            // Reset all values
            NumberOfGuesses = 0;
            MistakeCounter = 0;
            CharactersGuessed = new List<char>();
            // Generate a new random word
            WordGenerator wg = new WordGenerator();
            WordToGuess = wg.Word;
        }

        /// <summary>
        /// The character our user tried to guess
        /// </summary>
        /// <param name="c"></param>
        public void CharacterGuessed(string guessedChar)
        {
            // Increment the number of total guesses
            NumberOfGuesses++;
            // Add the character to guessed characters list
            CharactersGuessed.Add(guessedChar[0]);
        }

    }
}
