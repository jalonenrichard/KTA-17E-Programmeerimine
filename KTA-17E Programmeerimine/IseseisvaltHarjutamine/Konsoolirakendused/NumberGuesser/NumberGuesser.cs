using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumberGuesserProject
{
    /// <summary>
    /// Asks the user to think of a number and tries to guess it
    /// </summary>
    class NumberGuesser
    {
        #region Public Properties
        /// <summary>
        /// The maximum number that the user could have picked
        /// </summary>
        public int MaximumNumber { get; set; }

        /// <summary>
        /// The current known mimum value of the possible range of numbers the user could have picked
        /// </summary>
        public int CurrentGuessMinimum { get; private set; }

        /// <summary>
        /// The current known maximum value of the possible range of numbers that the user could have picked
        /// </summary>
        public int CurrentGuessMaximum { get; private set; }

        /// <summary>
        /// The number of times the computer has guessed a value
        /// </summary>
        public int NumberOfGuesses { get; private set; }
        #endregion

        #region Constructor
        /// <summary>
        /// Default constructor
        /// </summary>
        public NumberGuesser()
        {
            //Set default maximum number
            this.MaximumNumber = 100;
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// Ask the user to think of a number between 0 and MaximumNumber
        /// </summary>
        public void InformUser()
        {
            //Ask the user to pick a random number between 0 and MaximumNumber
            Console.WriteLine($"Think of a number between 0 and {MaximumNumber} and i will try to guess it");
            Console.ReadLine();
        }

        /// <summary>
        /// Keep asking the user for different number ranges until the number is guessed
        /// </summary>
        public void FindNumber()
        {
            //Initialize the properties
            this.NumberOfGuesses = 0;
            this.CurrentGuessMinimum = 0;
            this.CurrentGuessMaximum = this.MaximumNumber / 2;

            //Keep guessing number ranges until two numbers remain
            while (this.CurrentGuessMinimum != this.MaximumNumber)
            {
                this.NumberOfGuesses++;
                //Ask if the number is between minimum value (0 at first) and maximum value / 2 (50) at first
                Console.WriteLine($"Is the number between {this.CurrentGuessMinimum} and {this.CurrentGuessMaximum}?");
                //Get the user input
                string userAnswer = Console.ReadLine();

                //If userAnswer starts with 'y'...
                if (userAnswer?.ToLower().FirstOrDefault() == 'y')
                {
                    //Set the new max number
                    this.MaximumNumber = this.CurrentGuessMaximum;

                    //Set the next guess range
                    this.CurrentGuessMaximum = this.CurrentGuessMaximum - (this.CurrentGuessMaximum - this.CurrentGuessMinimum) / 2;
                }
                //If userAnswer is anything else
                else
                {
                    //minGuess value is now the last maxGuess + 1
                    this.CurrentGuessMinimum = this.CurrentGuessMaximum + 1;
                    //Helper value to calculate the new maxGuess value
                    int remainingDifference = this.MaximumNumber - this.CurrentGuessMaximum;
                    //Set the new maxGuess value
                    this.CurrentGuessMaximum += (int)Math.Ceiling(remainingDifference / 2f);
                }

                //If only 2 numbers remain...
                if (this.CurrentGuessMinimum + 1 == this.MaximumNumber)
                {
                    NumberOfGuesses++;
                    //Try to guess the number by asking if it's the lower of the 2
                    Console.WriteLine($"Is your number {this.CurrentGuessMinimum}?");
                    userAnswer = Console.ReadLine();
                    //If it is the lower one
                    if (userAnswer?.ToLower().FirstOrDefault() == 'y')
                    {
                        //break out of the while loop
                        break;
                    }
                    //if it was not the lower one..
                    else
                    {
                        //Assign the higher value to minGuess for displaying later
                        this.CurrentGuessMinimum = this.MaximumNumber;
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// Tell the user the number he thought of
        /// </summary>
        public void RevealNumber()
        {
            //Tell the user the number he picked
            Console.WriteLine($"** Your number is: {this.CurrentGuessMinimum} **" +
                $"\nNumber of guesses: {this.NumberOfGuesses}");
            Console.ReadLine();
        }
        #endregion
    }
}
