using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable to store the decimal value to convert
            int decimalNumber = 0;
            //Inform the user and ask to pick a decimal number they wish to convert
            Console.WriteLine("Decimal to binary converter");
            Console.Write("Enter the decimal number you wish to convert: ");

            //check if input was valid
            bool validInput = Int32.TryParse(Console.ReadLine(), out decimalNumber);
            //keep asking the user for an input until it's a valid integer
            while (!validInput || decimalNumber <= 0)
            {
                //ask for the input and try to parse it to an integer again
                Console.WriteLine("Invalid Input!");
                Console.Write("Enter the decimal number you wish to convert: ");
                validInput = Int32.TryParse(Console.ReadLine(), out decimalNumber);
            }
            //convert the decimal number to a binary number and return the result
            Console.WriteLine($"{decimalNumber} in decimal is {ConvertDecimalToBinary(decimalNumber)} in binary");
            Console.ReadLine();
        }

        /// <summary>
        /// Converts a decimal value to a binary value
        /// </summary>
        /// <param name="decimalValue">Decimal value to convert</param>
        /// <returns>binary value as string</returns>
        private static string ConvertDecimalToBinary(int decimalValue)
        {
            //Stringbuilder to store the binary value
            StringBuilder sb = new StringBuilder();
            // a counter to keep the binary values separated in groups of 4
            int counter = 0;
            //keep calculatin until the the decimal value is converted (equals 0)
            while (decimalValue != 0)
            {
                //no remainder, add a 0
                if (decimalValue % 2 == 0)
                {
                    //add a space when there's 4 binary values for readability
                    if (counter == 4)
                    {
                        sb.Append(" ");
                        //and set the counter back to 0
                        counter = 0;
                    }
                    //add a 0 to the binary value
                    sb.Append(0);
                    //new decimal value is halved
                    decimalValue = decimalValue / 2;
                    //binary counter
                    counter++;

                }
                //remainder is 1, add 1
                else if (decimalValue % 2 == 1)
                {
                    //add a space when there's 4 binary values for readability
                    if (counter == 4)
                    {
                        sb.Append(" ");
                        counter = 0;
                    }
                    //add a 1 to the binary value
                    sb.Append(1);
                    //half the decimalvalue
                    decimalValue = decimalValue / 2;
                    //binary counter
                    counter++;
                }
            }
            // convert the stringbuilder to a string
            string binaryReversed = sb.ToString();
            
            //reversed stringbuilder 1
            StringBuilder sbTwo = new StringBuilder();
            //go through the string created by the first stringbuilder in reverse order
            for (int i = binaryReversed.Length - 1; i >= 0; i--)
            {
                sbTwo.Append(binaryReversed[i]);
            }
            //return the binary value as string
            return sbTwo.ToString();
        }
    }
}
