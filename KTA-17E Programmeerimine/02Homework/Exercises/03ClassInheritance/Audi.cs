using System;
using System.Collections.Generic;
using System.Text;

namespace _03ClassInheritance
{
    /// <summary>
    /// Audi that inherits Car's methods and properties
    /// </summary>
    class Audi : Car
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="modelName">Name of the model</param>
        /// <param name="topSpeed">Top speed</param>
        /// <param name="numberOfDoors">Amount of doors</param>
        public Audi(string modelName, int topSpeed, int numberOfDoors) : base(modelName, topSpeed, numberOfDoors)
        {
            CarName = "Audi";
        }
    }
}
