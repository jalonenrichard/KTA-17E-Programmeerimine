using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05GuessMyNumber
{
    class Program
    {
        private static int userNumber, npcNumber;
        static void Main(string[] args)
        {
            Random random = new Random();
            npcNumber = random.Next(100);

            Console.WriteLine("Arvuti valis suvalise numbri 1-100, proovi see ära arvata!");

            GuessNumber();

            while (userNumber != npcNumber)
            {
                if (userNumber < npcNumber)
                {
                    Console.WriteLine("Liiga väike number");
                    GuessNumber();
                }
                else if (userNumber > npcNumber)
                {
                    Console.WriteLine("Liiga suur number");
                    GuessNumber();
                }
            }

            Console.WriteLine($"Õige! Arvuti number oli {npcNumber}");
            Console.ReadKey();
        }

        private static void GuessNumber()
        {
            Console.Write("Sisesta number: ");
            string inputString = Console.ReadLine();

            bool isNumber = Int32.TryParse(inputString, out userNumber);
            if (!isNumber || userNumber < 0 || userNumber > 100)
            {
                Console.WriteLine("Vigane sisend, ära tee nahka!");
                GuessNumber();
            }
        }
    }
}
