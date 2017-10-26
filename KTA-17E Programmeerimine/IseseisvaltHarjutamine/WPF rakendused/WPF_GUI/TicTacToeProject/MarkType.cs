using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeProject
{
    /// <summary>
    /// Possible current cell value
    /// </summary>
    public enum MarkType
    {
        /// <summary>
        /// The cell has not been clicked yet
        /// </summary>
        Free,
        /// <summary>
        /// The cell is an O
        /// </summary>
        Nought,
        /// <summary>
        /// The cell is an X
        /// </summary>
        Cross
    }
}
