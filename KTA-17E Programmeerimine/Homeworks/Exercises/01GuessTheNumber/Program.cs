using System;

namespace _01GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an instance of the NumberGuesser class
            var numberGuesser = new NumberGuesser();

            //Inform the user about the functionality of the program
            numberGuesser.InformUser();

            //Bug (keep asking) the user until they guess the random number
            numberGuesser.AskUserInput();

            //Congratulate the user for guessing the number and reveal the Random Number the NPC picked
            numberGuesser.RevealNumber();

            //Wait for the user to press a key so the console window would stay open
            Console.WriteLine("\nPress any key to exit");
            Console.ReadLine();
        }
    }
}
