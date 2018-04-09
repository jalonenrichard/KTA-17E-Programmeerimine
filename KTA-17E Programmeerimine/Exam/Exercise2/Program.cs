using System;
using System.Collections.Generic;

namespace Exercise2
{
    class Program
    {
        static readonly List<string> nameList = new List<string> { "Kaur", "Mattias", "Kristel", "Heleri", "Trevor", "Kristjan", "Kelli", "Kevin", "Maarika", "Laura" };
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta lause ning programm paneb nimed automaatselt suurteks t2htedeks.");

            Console.WriteLine();

            Console.Write("Sisend: ");
            string userInput = Console.ReadLine().Trim();

            Console.WriteLine();

            Console.WriteLine("V2ljund: " + MakeNamesCapital(userInput));

            Console.WriteLine();
            Console.WriteLine("Vajuta ykskoik millist nuppu, et v2ljuda programmist.");
            Console.ReadKey();
        }

        /// <summary>
        /// Check if the string contains any of the names and capitalize them
        /// </summary>
        /// <param name="userInput">input string</param>
        /// <returns>input string with names capitalized</returns>
        static string MakeNamesCapital(string userInput)
        {
            string outputString = "";
            List<string> inputList = new List<string>(userInput.Split(' '));
            List<string> outputList = new List<string>();

            foreach (string sona in inputList)
            {
                if (sona.Length > 1)
                {
                    string word = char.ToUpper(sona[0]) + sona.Substring(1).ToLower();

                    if (nameList.Contains(word))
                    {
                        outputList.Add(word);
                    }
                    else
                    {
                        outputList.Add(sona);
                    }
                }
                else
                {
                    outputList.Add(sona);
                }
            }

            foreach (string sona in outputList)
            {
                if (sona != "." && sona != "," && sona != "!" && sona != "?")
                {
                    outputString += sona + " ";
                }
                else
                {
                    outputString += sona;
                }
            }

            return outputString;
        }
    }
}
