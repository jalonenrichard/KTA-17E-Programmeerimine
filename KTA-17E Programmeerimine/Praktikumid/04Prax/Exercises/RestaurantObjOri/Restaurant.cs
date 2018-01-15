using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantObjOri
{
    class Restaurant
    {
        /// <summary>
        /// Name of the restaurant
        /// </summary>
        public string RestaurantName { get; private set; }

        /// <summary>
        /// Address of the restaurant
        /// </summary>
        public string RestaurantAddress { get; private set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="restaurantName">Name of the restaurant</param>
        /// <param name="restaurantAddress">Address of the restaurant</param>
        public Restaurant(string restaurantName, string restaurantAddress)
        {
            this.RestaurantName = restaurantName;
            this.RestaurantAddress = restaurantAddress;
        }

        /// <summary>
        /// Get the receipt for given tab
        /// </summary>
        /// <param name="tab">The tab you wish to get the receipt for</param>
        /// <returns></returns>
        public Receipt GetReceipt(Tab tab)
        {
            Receipt receipt = new Receipt(tab, this);
            return receipt;
        }
    }
}
