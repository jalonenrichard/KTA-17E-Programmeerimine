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
            int decimalNumber = 0;
            Console.WriteLine("Decimal to binary converter");
            Console.Write("Enter the decimal number you wish to convert: ");
            bool validInput = Int32.TryParse(Console.ReadLine(), out decimalNumber);
            while (!validInput || decimalNumber <= 0)
            {
                Console.WriteLine("Invalid Input!");
                Console.Write("Enter the decimal number you wish to convert: ");
                validInput = Int32.TryParse(Console.ReadLine(), out decimalNumber);
            }
            Console.WriteLine(ConvertDecimalToBinary(decimalNumber));
            Console.ReadLine();
        }

        private static string ConvertDecimalToBinary(int decimalValue)
        {
            StringBuilder sb = new StringBuilder();
            int counter = 0;
            while (decimalValue != 0)
            {
                if (decimalValue % 2 == 0)
                {
                    
                    if (counter == 4)
                    {
                        sb.Append(" ");
                        counter = 0;
                    }
                    sb.Append(0);
                    decimalValue = decimalValue / 2;
                    counter++;

                }
                else if (decimalValue % 2 == 1)
                {
                    
                    if (counter == 4)
                    {
                        sb.Append(" ");
                        counter = 0;
                    }
                    sb.Append(1);
                    decimalValue = decimalValue / 2;
                    counter++;
                }
            }
            string binaryReversed = sb.ToString();

            StringBuilder sbTwo = new StringBuilder();
            for (int i = binaryReversed.Length - 1; i >= 0; i--)
            {
                sbTwo.Append(binaryReversed[i]);
            }

            return sbTwo.ToString();
        }
    }
}
