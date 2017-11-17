using System;
using System.Collections.Generic;
using System.Text;

namespace _03ClassInheritance
{
    /// <summary>
    /// Base Class for a car object
    /// </summary>
    class Car
    {
        #region Public Properties

        /// <summary>
        /// Name of the car (make)
        /// </summary>
        public string CarName { get; set; }

        /// <summary>
        /// Model of the car
        /// </summary>
        public string CarModel { get; private set; }

        /// <summary>
        /// Top Speed of the car
        /// </summary>
        public double TopSpeed { get; private set; }

        /// <summary>
        /// Amount of doors the car has
        /// </summary>
        public int NumberOfDoors { get; private set; }

        /// <summary>
        /// Is handbrake on or off
        /// </summary>
        public bool HandBrakeOn { get; set; }
        #endregion

        #region Constructor
        /// <summary>
        /// Default Constructor
        /// </summary>
        public Car()
        {

        }

        /// <summary>
        /// Constructor for each car
        /// </summary>
        /// <param name="carModel">Model name</param>
        /// <param name="topSpeed">Top speed</param>
        /// <param name="numberOfDoors">Number of doors</param>
        public Car(string carModel, int topSpeed, int numberOfDoors)
        {
            CarModel = carModel;
            TopSpeed = topSpeed;
            NumberOfDoors = numberOfDoors;
        }
        #endregion

        #region Helper Methods
        /// <summary>
        /// Prints all the information about the current car
        /// </summary>
        public void PrintCarInfo()
        {
            // Inform the user about the information of current car
            Console.WriteLine($"The {CarName} {CarModel} has {NumberOfDoors} doors and a top speed of {TopSpeed} km/h");
        }

        /// <summary>
        /// Car accelerates to top speed
        /// </summary>
        public void Accelerate()
        {
            // check if handbrake is relased
            if (HandBrakeOn)
            {
                Console.WriteLine($"{CarName} {CarModel} cannot accelerate, the handbrake is on");
            }
            else
            {
                Console.WriteLine($"{CarName} {CarModel} accelerates to {TopSpeed} km/h");
            }
        }
        #endregion
    }
}
