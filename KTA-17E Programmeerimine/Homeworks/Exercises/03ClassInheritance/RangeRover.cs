using System;
using System.Collections.Generic;
using System.Text;

namespace _03ClassInheritance
{
    /// <summary>
    /// Range Rover that inherits Car's methods and properties
    /// </summary>
    class RangeRover : Car
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="carModel">Model name</param>
        /// <param name="topSpeed">Top speed</param>
        /// <param name="numberOfDoors">Amount of doors</param>
        public RangeRover(string carModel, int topSpeed, int numberOfDoors) : base(carModel, topSpeed, numberOfDoors)
        {
            CarName = "Range Rover";
        }
    }
}
