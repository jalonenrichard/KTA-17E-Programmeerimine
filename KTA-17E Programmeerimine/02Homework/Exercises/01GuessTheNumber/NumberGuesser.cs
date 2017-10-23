using System;
using System.Collections.Generic;
using System.Text;

namespace _01GuessTheNumber
{
    class NumberGuesser
    {
        #region Public Properties

        /// <summary>
        /// The random number that the NPC picks
        /// </summary>
        public int RandomNumber { get; private set; }

        /// <summary>
        /// The number that our user inserts while trying to guess the random number
        /// </summary>
        public int UserNumber { get; set; }

        /// <summary>
        /// The number of guesses it took for the user to guess the random number
        /// </summary>
        public int NumberOfGuesses { get; private set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Default Constructor
        /// </summary>
        public NumberGuesser()
        {
            //Pick a random number from 1-100 when we create an instance of NumberGuesser
            this.RandomNumber = PickTheRandomNumber();
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Inform the user about the program functionality
        /// </summary>
        public void InformUser()
        {
            Console.WriteLine("I picked a random number between 1 and 100, your job is to try and guess the number.");
        }

        /// <summary>
        /// Bug the user until they guess the random number
        /// </summary>
        public void AskUserInput()
        {
            //Keep bugging the user until they guess the random number our NPC picked
            while (this.UserNumber != this.RandomNumber)
            {
                //Add +1 to the amount of tries the user has guessed
                this.NumberOfGuesses++;
                //Ask for the input
                Console.Write("Your guess: ");
                //Store the input to a local variable
                string userInput = Console.ReadLine();

                //Remove any extra whitespace if there is any
                userInput = userInput.Trim();

                //a local variable to store the parsed user input number
                int userNumber;

                //Check if the input is valid
                //If the user input is empty
                if (userInput == string.Empty)
                {
                    //... inform the user about their mistake
                    Console.WriteLine("You entered absolutely nothing, nice try though, try again!");
                }
                //If the user did not enter an integer...
                else if (!Int32.TryParse(userInput, out userNumber))
                {
                    //... inform the user about their mistake
                    Console.WriteLine($"{userInput} is not a valid number, please enter an integer.");

                }
                //If the user entered a number that is 0 or less
                else if (Int32.TryParse(userInput, out userNumber) && userNumber < 1)
                {
                    //... inform the user about their mistake
                    Console.WriteLine($"{userNumber} is too small of a number, i picked a number starting from 1 and up to 100, try again.");
                }
                else if (Int32.TryParse(userInput, out userNumber) && userNumber > 100)
                {
                    //... inform the user about their mistake
                    Console.WriteLine($"{userNumber} is too large of a number, i picked a number starting from 1 and up to 100, try again.");
                }
                //If the userInput is valid
                else
                {
                    //Store the value to our UserNumber property
                    this.UserNumber = int.Parse(userInput);

                    //Check if the user guessed too high or too low
                    //If the number was lower than the random number...
                    if (this.UserNumber < this.RandomNumber)
                    {
                        //...inform the user that the number they picked is too low
                        Console.WriteLine($"Too low! The number i picked is higher than {this.UserNumber}, try again!");
                    }
                    //If the user entered a number too high...
                    else if (this.UserNumber > this.RandomNumber)
                    {
                        //Inform the user that it's too high
                        Console.WriteLine($"Too high! The number i picked is lower than {this.UserNumber}, try again!");
                    }
                }


            }
        }

        /// <summary>
        /// Congratulate the user for guessing the number, reveal the random number and the amount of tries it took
        /// </summary>
        public void RevealNumber()
        {
            Console.WriteLine("\n*** Correct! You guessed the number! ***");
            //Tell the user the random number picked at start to validate
            Console.WriteLine($"The number i picked: {this.RandomNumber}");
            //Let he user know how many tries it took them to guess the number
            Console.WriteLine($"It took you {this.NumberOfGuesses} tries to guess my number");
        }

        #endregion

        #region Helper Methods

        /// <summary>
        /// Pick a random number between 1 and 100
        /// </summary>
        /// <returns></returns>
        private int PickTheRandomNumber()
        {
            //Create a new instance of Random object
            var randomNumber = new Random();
            //Pick the random number from 1 to 100
            return randomNumber.Next(1, 101);
        }

        #endregion
    }

}