using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumberTriangle
{
    class Program
    {
        private static int triangleNumber, triangleHeight;
        static void Main(string[] args)
        {
            AskTriangleInputs();
            Triangle triangle = new Triangle();
        }

        private static void AskTriangleInputs()
        {
            Console.Write("Enter a base number you wish to build the triangle with: ");
            string baseNumber = Console.ReadLine();
            bool baseIsNumber = Int32.TryParse(baseNumber, out triangleNumber);
            if (!baseIsNumber || triangleNumber < 0)
            {
                Console.WriteLine("Invalid Input, try again!");
                AskTriangleInputs();
            }

            Console.Write("How tall (amount of lines) should the triangle be: ");
            string heightString = Console.ReadLine();
            bool heightIsNumber = Int32.TryParse(heightString, out triangleHeight);
            if (heightIsNumber && triangleHeight > 0)
            {
                return;
            }
            else
            {
                Console.WriteLine("Invalid Input, try again!");
                AskTriangleInputs();
            }
        }
    }
}
