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
            
            DiscountCalc calc = new DiscountCalc();
            calc.AskUSerInput();
            Console.WriteLine();

            calc.IsFrequent = false;
            calc.CalculatePrice();
            calc.DisplayCustomerPrice();

            Console.WriteLine();

            calc.IsFrequent = true;
            calc.CalculatePrice();
            calc.DisplayFrequentPrice();
            Console.ReadLine();
        }
    }
}
