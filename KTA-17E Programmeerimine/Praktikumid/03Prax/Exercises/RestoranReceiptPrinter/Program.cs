using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranReceiptPrinter
{
    class Program
    {
        static List<double> foodList = new List<double>();
        private static double currentPrice = 0;
        private static double percentage;

        static void Main(string[] args)
        {
            Console.WriteLine("Some text about the company");
            Console.WriteLine("------------------------------");

            AskInput();
            CalculatePrice();
            
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Subtotal: {currentPrice}");
            
            Console.WriteLine($"15% Gratuity: {percentage}");

            Console.WriteLine($"Price: {currentPrice - percentage}");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();

        }
        static void AskInput()
        {
            while (currentPrice != -1)
            {
                Console.Write("Enter price of item [-1 to quit]: ");
                bool isNumber = double.TryParse(Console.ReadLine(), out currentPrice);
                if (!isNumber)
                {
                    Console.WriteLine("Invalid input");
                }
                else
                {
                    foodList.Add(currentPrice);
                }
            }
        }
        static void CalculatePrice()
        {
            for (int i = 0; i < foodList.Count; i++)
            {
                currentPrice += foodList[i];
            }
            currentPrice += 2;
            percentage = currentPrice * 0.15;
        }
    }
}
