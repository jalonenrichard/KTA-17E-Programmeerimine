using System;
using System.Collections.Generic;
using System.Text;

namespace BlackjackProject
{
    class House : Player
    {

        /// <summary>
        /// Default Constructor
        /// </summary>
        /// <param name="name"></param>
        public House(string name) : base(name)
        {
            IsHouse = true;
        }

    }
}
