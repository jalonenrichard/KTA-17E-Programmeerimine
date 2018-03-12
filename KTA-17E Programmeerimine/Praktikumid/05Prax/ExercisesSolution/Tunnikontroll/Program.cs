using System;
using System.Text;

namespace Tunnikontroll
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programm muudab etteantud lause sonades tähtede järjekorra");
            Console.Write("Sisesta lause: ");
            string userInput = Console.ReadLine();

            WordMixer wordMixer = new WordMixer(userInput);
            wordMixer.MixWords();

            foreach(string word in wordMixer.MixedWords)
            {
                Console.Write (word + " ");
            }
            Console.ReadKey();
        }
    }
}
