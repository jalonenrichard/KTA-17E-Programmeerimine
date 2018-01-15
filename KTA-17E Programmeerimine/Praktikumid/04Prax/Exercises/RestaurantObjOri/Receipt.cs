using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantObjOri
{
    class Receipt
    {
        /// <summary>
        /// Tab to create the receipt for
        /// </summary>
        private Tab _tab { get; set; }

        /// <summary>
        /// Restaurant of the tab
        /// </summary>
        private Restaurant _restaurant { get; set; }

        public double TotalSum { get; private set; }

        private double _discount { get; set; }

        /// <summary>
        /// Default Constructor
        /// </summary>
        /// <param name="tab">Tab to create the receipt for</param>
        public Receipt(Tab tab, Restaurant restaurant)
        {
            this._tab = tab;
            this._restaurant = restaurant;
            _discount = 15;
        }

        /// <summary>
        /// Makes a string version of the Receipt
        /// </summary>
        /// <returns>Receipt as a string</returns>
        public override string ToString()
        {
            string tempReceipt = "";
            tempReceipt += _restaurant.RestaurantName + "\n";
            tempReceipt += _restaurant.RestaurantAddress + "\n";

            tempReceipt += "----------\n";
            // Go through the list of all the items that given tab bought and add them to the string
            foreach (double d in _tab.ItemList)
            {
                tempReceipt += d + " $\n";
            }
            tempReceipt += "----------\n";
            tempReceipt += "Subtotal: " + _tab.TabSummary + "\n";
            tempReceipt += _discount + " % discount\n";
            CalculateDiscount();
            // Finally print the Summary 
            tempReceipt += "Total: " + TotalSum + " $";
            return tempReceipt;
        }

        private void CalculateDiscount()
        {
            TotalSum = _tab.TabSummary - ((_discount/100) * _tab.TabSummary);
            TotalSum = Math.Round(TotalSum, 2);
        }
    }

}
