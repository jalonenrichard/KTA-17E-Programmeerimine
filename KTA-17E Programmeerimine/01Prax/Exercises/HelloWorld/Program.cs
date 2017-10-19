using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            String helloWorld = "Hello World!";
            String pressAnyKey = "Press any key to continue";

            Console.WriteLine(helloWorld);
            Console.WriteLine(pressAnyKey);

            pressAnyKey = "nahk";

            Console.ReadKey();
        }
    }
}