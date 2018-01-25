using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanWPF
{
    class HangmanGame
    {
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
        /// Default Constructor
        /// </summary>
        public HangmanGame()
        {
            // Reset all values
            NumberOfGuesses = 0;
            MistakeCounter = 0;
            // Generate a new random word
            WordGenerator wg = new WordGenerator();
            WordToGuess = wg.Word;
        }
    }
}
