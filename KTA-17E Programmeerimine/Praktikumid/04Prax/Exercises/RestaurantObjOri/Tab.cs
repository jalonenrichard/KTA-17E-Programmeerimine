using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantObjOri
{
    class Tab
    {
        /// <summary>
        /// Summary of all the ordered items
        /// </summary>
        public double TabSummary { get; set; }

        /// <summary>
        /// List of items bought
        /// </summary>
        public List<double> ItemList = new List<double>();

        /// <summary>
        /// Default constructor
        /// </summary>
        public Tab()
        {

        }

        /// <summary>
        /// Add the value of the item to this tab's total sum
        /// </summary>
        /// <param name="sum">item value</param>
        #region public methods
        public void Add(double value)
        {
            // Add the value to the list for the future receipt print
            ItemList.Add(value);
            // Add the value of given item to the sum of current tab
            TabSummary += value;
        }
        #endregion
    }
}
