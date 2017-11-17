using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimePractice
{
    class Program
    {
        /// <summary>
        /// Current dateTimeNow
        /// </summary>
        private static DateTime dateTimeNow = DateTime.Now;

        static void Main(string[] args)
        {
            

            #region 01 Current Date Time

            /*
                        1. Write a program in C to print the current time. Go to the editor
             
                        Expected Output :
              
                        The Current time is : Thu Aug 03 13:38:58 2017
             */
            Console.WriteLine("Print the current date and time");
            Console.WriteLine($"The Current time is: {dateTimeNow}");

            #endregion

            // horizontal line between exercises
            Console.WriteLine("--------------------------");

            #region 02 Time passed since start of the month

            /*
                        2.Write a program in C to compute the number of seconds passed since the beginning of the month. Go to the editor

                        Expected Output :

                        222084 seconds passed since the beginning of the month.
            */

            Console.WriteLine("Calculate the time passed since the start of current month in seconds");
            // create the date that contains the start of the month so we can subtract it
            var startDate = new DateTime(dateTimeNow.Year, dateTimeNow.Month, 1);
            // subtract the start of the month from the current time and convert it to seconds
            var timePassed = dateTimeNow.Subtract(startDate).TotalSeconds;
            // cast the seconds to an int and display the result
            Console.WriteLine($"{(int)timePassed} seconds passed since {startDate}");

            #endregion

            Console.ReadKey();
        }

    }
}
