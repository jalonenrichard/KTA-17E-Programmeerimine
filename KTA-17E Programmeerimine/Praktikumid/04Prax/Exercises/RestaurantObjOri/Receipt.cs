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
        /// Default Constructor
        /// </summary>
        /// <param name="tab">Tab to create the receipt for</param>
        public Receipt(Tab tab)
        {
            this._tab = tab;
        }

        /// <summary>
        /// Makes a string version of the Receipt
        /// </summary>
        /// <returns>Receipt as a string</returns>
        public override string ToString()
        {
            string tempReceipt = "";
            // Go through the list of all the items that given tab bought and add them to the string
            foreach (double d in _tab.ItemList)
            {
                tempReceipt += d + " $\n";
            }
            // Finally print the Summary 
            tempReceipt += "Total: " + _tab.TabSummary + " $";
            return tempReceipt;
        }
    }

}
