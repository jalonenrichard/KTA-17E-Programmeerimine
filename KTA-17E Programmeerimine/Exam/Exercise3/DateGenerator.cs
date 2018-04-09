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
            DateTime outputDate = new DateTime();
            bool successfulGeneration = false;
            while (!successfulGeneration)
            {
                try
                {
                    Random r = new Random();
                    outputDate = new DateTime(r.Next(MinYear, MaxYear), r.Next(1, 13), r.Next(1, 32), r.Next(0, 24), r.Next(0, 60), r.Next(0, 60));
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
