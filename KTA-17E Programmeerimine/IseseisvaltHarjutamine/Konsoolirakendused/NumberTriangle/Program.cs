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
            CreateTriangle();
            Console.ReadLine();
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

        private static void CreateTriangle()
        {
            int currentHeight = triangleHeight;
            for (int i = 0; i < triangleHeight; i++)
            {
                Console.WriteLine();
                for (int j = currentHeight; j > 0; j--)
                {
                    Console.Write(triangleNumber);
                }
                currentHeight--;
            }
        }
    }
}
