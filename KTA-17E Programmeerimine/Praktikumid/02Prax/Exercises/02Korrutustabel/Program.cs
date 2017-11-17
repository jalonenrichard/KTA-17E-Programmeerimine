using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Korrutustabel
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.Write(i + "\t");

                for (int j = 1; j <= 10; j++)
                {
                    if (i > 0)
                    {
                        Console.Write(i * j + "\t");
                    } else
                    {
                        Console.Write(j + "\t");
                    }
                }

                Console.WriteLine();

            }

            Console.ReadLine();
        }
    }
}
