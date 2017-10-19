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
            
        }

        private void AskTriangleInputs()
        {
            Console.Write("Enter a number you wish to build the triangle with: ");
            string baseNumber = Console.ReadLine();

            Console.Write("How tall (amount of lines) should the triangle be: ");
            string heightString = Console.ReadLine();
        }
    }
}
