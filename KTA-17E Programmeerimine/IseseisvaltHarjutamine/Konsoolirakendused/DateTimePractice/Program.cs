using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 01 Current Date Time
            // First exercise
            /*
             * 1. Write a program in C to print the current time. Go to the editor
             *
              *  Expected Output :
              *
              *  The Current time is : Thu Aug 03 13:38:58 2017
             */

            Console.WriteLine($"The Current time is: {DateTime.Now}");

            #endregion

            Console.ReadKey();
        }

    }
}
