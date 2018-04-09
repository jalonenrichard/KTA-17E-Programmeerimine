using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3
{

    class DateGenerator
    {
        public int MaxYear { get; set; }
        public int MinYear { get; set; }

        public DateGenerator(int maxYear, int minYear)
        {
            MaxYear = maxYear;
            MinYear = minYear;
        }

        public DateTime GenerateRandomDay()
        {
            int year, month;
            Random r = new Random();
            return new DateTime(year = r.Next(MinYear, MaxYear), month = r.Next(1, 13), r.Next(1, DateTime.DaysInMonth(year, month) + 1), r.Next(0, 24), r.Next(0, 60), r.Next(0, 60));
        }
    }
}
