using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program decription
            Console.WriteLine("Programm kysib teilt nimesid kuni sisestate -1 ning hiljem kuvab koik sisestatud nimed.");
            Console.WriteLine();

            //Ask for user input and save it into a List of strings
            List<string> nameList = new List<string>(AskNames());

            //Print out the output
            if (nameList.Any())
            {
                Console.WriteLine();
                Console.WriteLine("Sisestatud nimed:");
                foreach (string name in nameList)
                {
                    Console.WriteLine(name);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Vajuta ykskoik millist nuppu, et v2ljuda programmist.");
            Console.ReadKey();
        }

        /// <summary>
        /// Ask the user to input names until -1 is inserted and return a list of names
        /// </summary>
        /// <returns>a list of names the user typed in</returns>
        static List<string> AskNames()
        {
            List<string> nameList = new List<string>();
            string userInput = "";
            while (userInput != "-1")
            {
                string nimi = "";
                Console.Write("Sisesta nimi: ");
                userInput = Console.ReadLine().Trim();
                if (userInput != "-1" && userInput != "")
                {
                    // Kui mitu nime
                    if (userInput.Contains(" "))
                    {
                        string[] nimed = userInput.Split(' ');
                        foreach (string name in nimed)
                        {
                            nimi += char.ToUpper(name[0]) + name.Substring(1).ToLower() + " ";
                        }
                        nameList.Add(nimi);
                    }
                    else
                    {
                        nimi = char.ToUpper(userInput[0]) + userInput.Substring(1).ToLower();
                        nameList.Add(nimi);
                    }
                }
            }
            return nameList;
        }
    }
}
