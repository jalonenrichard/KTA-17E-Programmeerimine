using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Exercise4
{
    class Program
    {
        static List<DateTime> dateList = new List<DateTime>();

        static void Main(string[] args)
        {
            PopulateDateList(30, 1940, 2010);

            Console.WriteLine("Original list: ");
            foreach (var item in dateList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine($"Maximum age: {FindMaximumAge()}");

            Console.WriteLine();
            Console.WriteLine($"Average age: {FindAverageAge()}");

            Console.WriteLine();
            Console.WriteLine($"Minimal age: {FindMinimalAge()}");

            Console.WriteLine();
            //https://stackoverflow.com/questions/6286868/convert-month-int-to-month-name
            Console.WriteLine($"Most birthays in: {CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(FindMostBirthdaysMonth())}");

            Console.WriteLine();
            Console.WriteLine($"Sorted list: ");
            SortListAscending();
            foreach (var item in dateList)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }

        static void SortListAscending()
        {
            dateList.Sort();
        }

        static int FindMostBirthdaysMonth()
        {
            List<int> monthList = new List<int>();
            foreach (var item in dateList)
            {
                monthList.Add(item.Month);
            }
            //https://stackoverflow.com/questions/355945/find-the-most-occurring-number-in-a-listint
            return monthList.GroupBy(i => i).OrderByDescending(grp => grp.Count()).Select(grp => grp.Key).First();
        }

        static int FindMinimalAge()
        {
            DateTime highest = dateList.Max();
            var today = DateTime.Today;
            var age = today.Year - highest.Year;
            return age;
        }

        static int FindAverageAge()
        {
            var today = DateTime.Today;
            int ageSum = 0;
            foreach (var item in dateList)
            {
                int age = today.Year - item.Year;
                ageSum += age;
            }
            return ageSum / dateList.Count;
        }

        static int FindMaximumAge()
        {
            // https://stackoverflow.com/questions/9/how-do-i-calculate-someones-age-in-c
            DateTime lowest = dateList.Min();
            var today = DateTime.Today;
            var age = today.Year - lowest.Year;
            return age;
        }


        static void PopulateDateList(int entryCount, int minYear, int maxYear)
        {
            for (int i = 0; i < entryCount; i++)
            {
                dateList.Add(GenerateRandomDay(minYear, maxYear));
            }
        }

        public static DateTime GenerateRandomDay(int minYear, int maxYear)
        {
            DateTime outputDate = new DateTime();
            bool successfulGeneration = false;
            while (!successfulGeneration)
            {
                try
                {
                    Random r = new Random();
                    outputDate = new DateTime(r.Next(minYear, maxYear), r.Next(1, 13), r.Next(1, 32), r.Next(0, 24), r.Next(0, 60), r.Next(0, 60));
                    successfulGeneration = true;
                }
                catch
                {

                }
            }
            return outputDate;

        }
    }
}
