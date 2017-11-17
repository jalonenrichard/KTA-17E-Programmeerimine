using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranReceiptPrinter
{
    class Program
    {
        /// <summary>
        /// List to store all the price values
        /// </summary>
        static List<double> foodList = new List<double>();

        /// <summary>
        /// variable to store the current (last) price
        /// </summary>
        private static double currentPrice = 0;

        /// <summary>
        /// Variable to store the 15% value of our price
        /// </summary>
        private static double percentage;

        /// <summary>
        /// Variable to store the last (total) price
        /// </summary>
        private static double totalPrice;

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Some text about the company");
            Console.WriteLine("------------------------------");

            //Ask the user to enter prices until they type -1
            AskInput();
            //Calculate the price, percentage and the subtotal
            CalculatePrice();

            //Display results
            DisplayResults();

        }

        /// <summary>
        /// Ask the user to enter a price until they type -1
        /// </summary>
        static void AskInput()
        {
            while (currentPrice != -1)
            {
                Console.Write("Enter price of item [-1 to quit]: ");
                bool isNumber = double.TryParse(Console.ReadLine(), out currentPrice);
                if (!isNumber)
                {
                    // keep asking, inform about invalid input
                    Console.WriteLine("Invalid input");
                }
                else
                {
                    // if the parsing succeeded, add the price to our List
                    foodList.Add(currentPrice);
                }
            }
        }

        /// <summary>
        /// Calculate the price, percentage and subtotal
        /// </summary>
        static void CalculatePrice()
        {
            for (int i = 0; i < foodList.Count; i++)
            {
                currentPrice += foodList[i];
            }
            currentPrice += 2;
            percentage = currentPrice * 0.15;
            totalPrice = currentPrice - percentage;
        }

        /// <summary>
        /// Inform the user about the prices and percentages that we calculated
        /// </summary>
        static void DisplayResults()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Subtotal: €{currentPrice.ToString("#.##")}");

            Console.WriteLine($"15% Gratuity: €{percentage.ToString("#.##")}");

            Console.WriteLine($"Price: €{totalPrice.ToString("#.##")}");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }
    }
}
