using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04SumOfTwoNumbers
{
    class Program
    {
        private static double numOne, numTwo;

        static void Main(string[] args)
        {
            AskWhichFunction();
        }

        private static void AskWhichFunction()
        {
            Console.Write("Kas soovid liita(1), lahutada(2), korrutada(3) või jagada(4)? : ");
            string sisend = Console.ReadLine();

            Calculator calculator = new Calculator();

            switch (sisend)
            {
                case "1":
                    Console.WriteLine("Valisid liitmise");
                    AskNumbers();
                    Console.WriteLine($"\n{numOne} + {numTwo} = {calculator.AddTwoNumbers(numOne, numTwo)}");
                    Console.ReadKey();
                    break;
                case "2":
                    Console.WriteLine("Valisid lahutamise");
                    AskNumbers();
                    Console.WriteLine("\n" + numOne + " - " + numTwo + " = " + calculator.SubtractTwoNumbers(numOne, numTwo));
                    Console.ReadKey();
                    break;
                case "3":
                    Console.WriteLine("Valisid korrutamise");
                    AskNumbers();
                    Console.WriteLine("\n" + numOne + " * " + numTwo + " = " + calculator.MultiplyTwoNumbers(numOne, numTwo));
                    Console.ReadKey();
                    break;
                case "4":
                    Console.WriteLine("Valisid jagamise");
                    AskNumbers();
                    calculator.DivideTwoNumbers(numOne, numTwo);
                    Console.WriteLine("\n" + numOne + " / " + numTwo + " = " + calculator.DivideTwoNumbers(numOne, numTwo));
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Vigane sisend");
                    AskWhichFunction();
                    break;
            }
        }

        private static void AskNumbers()
        {
            Console.Write("Sisesta esimene arv: ");
            string firstNumber = Console.ReadLine();
            bool firstResult = Double.TryParse(firstNumber, out numOne);
            if (!firstResult)
            {
                Console.WriteLine("Vigane sisend");
                numOne = 0;
                AskNumbers();
            }

            Console.Write("Sisesta teine arv: ");
            string secondNumber = Console.ReadLine();
            bool secondResult = Double.TryParse(secondNumber, out numTwo);
            if (secondResult)
            {
                return;
            }
            else
            {
                Console.WriteLine("Vigane sisend");
                numTwo = 0;
                AskNumbers();
            }
        }

    }


}
