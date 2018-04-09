using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            int minYear;
            int maxYear;
            int timesToGenerate;
            string userInput;

            do
            {
                Console.Write("Minimaalne aasta: ");
                userInput = Console.ReadLine();
            } while (!int.TryParse(userInput, out minYear));

            do
            {
                Console.Write("Maksimaalne aasta: ");
                userInput = Console.ReadLine();
            } while (!int.TryParse(userInput, out maxYear));

            do
            {
                Console.Write("Genereeritavate andmete hulk: ");
                userInput = Console.ReadLine();
            } while (!int.TryParse(userInput, out timesToGenerate));

            DateGenerator dateGenerator = new DateGenerator(maxYear, minYear);
            for (int i = 0; i < timesToGenerate; i++)
            {
                Console.WriteLine(dateGenerator.GenerateRandomDay());
            }

            Console.WriteLine();
            Console.WriteLine("Vajuta ykskoik millist nuppu, et v2ljuda programmist.");
            Console.ReadKey();
        }


    }
}
