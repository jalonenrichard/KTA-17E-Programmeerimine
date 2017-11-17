using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02StringPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            String name = "";

            Console.Write("Sisesta oma nimi: ");
            name = Console.ReadLine();

            Console.WriteLine("\nTere, " + name + "! Õpid teist korda programmeerimist");

            Console.WriteLine("\nPress any key to continue");
            Console.ReadLine();
        }
    }
}
