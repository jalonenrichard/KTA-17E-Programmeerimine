using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03UserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";

            Console.Write("Sisesta tekst: ");
            input = Console.ReadLine();

            Console.WriteLine("\nSisestasid: " + input);
            Console.ReadKey();
        }
    }
}
