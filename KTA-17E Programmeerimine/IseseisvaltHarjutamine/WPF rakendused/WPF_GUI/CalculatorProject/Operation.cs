using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculatorProject
{
    /// <summary>
    /// Holds information about a single calculator operation between 2 numbers
    /// </summary>
    public class Operation
    {
        #region Public Properties
        /// <summary>
        /// Left side of the operation
        /// </summary>
        public string LeftSide { get; set; }

        /// <summary>
        /// Right side of the operation
        /// </summary>
        public string RightSide { get; set; }

        /// <summary>
        /// The type of operation to perform
        /// </summary>
        public OperationType OperationType { get; set; }
        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public Operation()
        {
            //Default values for the left and right side of the equation, empty string instead of null
            this.LeftSide = string.Empty;
            this.RightSide = string.Empty;
        }
        
        #endregion
    }
}