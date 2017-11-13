using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Allahindlus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Price: ");
            double price = double.Parse(Console.ReadLine());
            DiscountCalc calc = new DiscountCalc(price);
            calc.IsFrequent = false;
            calc.CalculatePrice();
            calc.DisplayCustomerPrice();
            calc.IsFrequent = true;
            calc.CalculatePrice();
            calc.DisplayFrequentPrice();
            Console.ReadLine();
        }
    }
}
