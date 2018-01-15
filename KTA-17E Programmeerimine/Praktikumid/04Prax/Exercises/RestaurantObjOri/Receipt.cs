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

        /// <summary>
        /// Default Constructor
        /// </summary>
        /// <param name="tab">Tab to create the receipt for</param>
        public Receipt(Tab tab, Restaurant restaurant)
        {
            this._tab = tab;
            this._restaurant = restaurant;
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
            // Finally print the Summary 
            tempReceipt += "Total: " + _tab.TabSummary + " $";
            return tempReceipt;
        }
    }

}
