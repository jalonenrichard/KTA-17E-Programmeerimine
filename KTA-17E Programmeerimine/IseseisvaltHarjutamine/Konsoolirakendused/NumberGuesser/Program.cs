using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumberGuesserProject
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *Create a new instance of the NumberGuesser class called numberGuesser
             *NumberGuesser numberGuesser = new NumberGuesser();
             *The same thing, shorter, Visual Studio assigns the var type automatically when defined
             */
            var numberGuesser = new NumberGuesser();

            //Change the maximum guess range to 500
            numberGuesser.MaximumNumber = 100;

            //Ask the user to think of a number
            numberGuesser.InformUser();

            //Discover the number 
            numberGuesser.FindNumber();

            //Tell the user the number he/she thought ouf
            numberGuesser.RevealNumber();
        }
    }
}