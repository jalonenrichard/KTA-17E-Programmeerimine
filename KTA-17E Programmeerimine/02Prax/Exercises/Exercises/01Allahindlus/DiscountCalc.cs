using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Allahindlus
{
    class DiscountCalc
    {
        public bool IsFrequent { get; set; }
        public double Price { get; set; }

        private double FrequentPrice { get; set; }
        private double CustomerPrice { get; set; }
        private double FrequentPercent { get; set; }
        private double CustomerPercent { get; set; }

        public DiscountCalc(double price)
        {
            Price = price;
        }

        public void CalculatePrice()
        {
            if (IsFrequent)
            {
                if (Price <= 0)
                {
                    Console.WriteLine($"{Price} is not a vaid input.");
                }
                if (Price > 50 && Price < 250)
                {
                    FrequentPercent = 0.8;
                    FrequentPrice = Price * FrequentPercent;
                }
                else if (Price >= 250 && Price < 350)
                {
                    FrequentPercent = 0.7;
                    FrequentPrice = Price * FrequentPercent;
                }
                else
                {
                    FrequentPercent = 0.6;
                    FrequentPrice = Price * FrequentPercent;
                }
            }
            else
            {
                if (Price <= 0)
                {
                    Console.WriteLine($"{Price} is not a vaid input.");
                }
                if (Price > 50 && Price < 250)
                {
                    CustomerPercent = 0.9;
                    CustomerPrice = Price * CustomerPercent;
                }
                else if (Price >= 250 && Price < 350)
                {
                    CustomerPercent = 0.8;
                    CustomerPrice = Price * CustomerPercent;
                }
                else
                {
                    CustomerPercent = 0.7;
                    CustomerPrice = Price * CustomerPercent;
                }
            }

        }
        public void DisplayCustomerPrice()
        {
            Console.WriteLine("Regular Customer");
            if (CustomerPercent == 0.9)
            {
                Console.WriteLine("Discount: 10%");

            }
            else if (CustomerPercent == 0.8)
            {
                Console.WriteLine("Discount: 20%");
            }
            else if (CustomerPercent == 0.7)
            {
                Console.WriteLine("Discount: 30%");
            }
            Console.WriteLine($"Price: {CustomerPrice}");
        }

        public void DisplayFrequentPrice()
        {
            Console.WriteLine("Frequent");
            if (FrequentPercent == 0.8)
            {
                Console.WriteLine("Discount: 20%");

            }
            else if (FrequentPercent == 0.7)
            {
                Console.WriteLine("Discount: 30%");
            }
            else if (FrequentPercent == 0.6)
            {
                Console.WriteLine("Discount: 40%");
            }
            Console.WriteLine($"Price: {FrequentPrice}");
        }
    }
}
