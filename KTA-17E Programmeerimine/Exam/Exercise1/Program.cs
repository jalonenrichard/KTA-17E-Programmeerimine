using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
               Luua programm mis küsib inimeste nimesi niikaua kuni sisestatakse erimärk „-1“. 
               Iga sisestatud nimi lisatakse massiivi mis kuvatakse kasutajale programmi lõpus välja. 
               Kindlasti tuleb veenduda, et esimene täht oleks suur. Selle võid lahendada nii, 
               et palud kasutajal sisestada sisendi õigel kujul või siis vaikimisi teed programmis esimese tähe alati suureks.
             */
            Console.WriteLine("Programm kysib teilt nimesid kuni sisestate -1 ning hiljem kuvab koik sisestatud nimed.");
            Console.WriteLine();

            List<string> nameList = new List<string>(AskNames());
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
                Console.Write("Sisesta nimi: ");
                userInput = Console.ReadLine().Trim();
                if (userInput != "-1" && userInput != "")
                {
                    nameList.Add(userInput);
                }
            }
            return nameList;
        }
    }
}
