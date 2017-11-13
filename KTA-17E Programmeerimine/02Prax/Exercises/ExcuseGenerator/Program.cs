using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcuseGenerator
{
    class Program
    {
        private static string userInput;
        private static List<string> excuseArray = new List<string>();
        static void Main(string[] args)
        {
            AskInput();
            AddToArray();
            Console.WriteLine(excuseArray[ChooseExcuse()]);
            Console.ReadLine();
        }

        private static void AskInput()
        {
            Console.Write("Excuses (separated by commas): ");
            userInput = Console.ReadLine();
        }

        private static void AddToArray()
        {
            excuseArray = userInput.Split(',').ToList<string>();
        }

        private static int ChooseExcuse()
        {
            Random rnd = new Random();
            return rnd.Next(0, excuseArray.Count());
        }
    }
}
