using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the game Hangman");
            // TESTS

            // TEST the WordGenerator
            WordGenerator wg = new WordGenerator();
            Console.WriteLine(wg.Word);
            Console.ReadKey();
        }
    }
}
