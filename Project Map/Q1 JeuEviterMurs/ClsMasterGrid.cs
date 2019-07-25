using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Project_Map
{
    /// <summary>
    /// Represents an object that is the Master Grid. The Master grid is a very large, non visual grid thats stored in the memory.
    /// The Master Grid holds the values for the whole map, in forms of data that will be placed in squares.
    /// </summary>
    public class ClsMasterGrid
    {
        private List<ClsMapSquare> m_colMapSquare;
        private int[,] m_tabMap;

        /// <summary>
        /// Creates a MasterGrid, which is a big array of int. The Table is filled with zeros.
        /// </summary>
        /// <param name="pRow">Number of Rows in the MasterGrid.</param>
        /// <param name="pCol">Number of Columns in the MasterGrid.</param>
        public ClsMasterGrid(int pRow, int pCol)
        {
            m_colMapSquare = new List<ClsMapSquare>();
            m_tabMap = new int[pRow,pCol];
        }
        
        /// <summary>
        /// Creates a MasterGrid, which is a big array of int. The Table is filled with zeros.
        /// </summary>
        /// <param name="pRow">Number of Rows in the MasterGrid.</param>
        /// <param name="pCol">Number of Columns in the MasterGrid.</param>
        /// <param name="pNumber">The table of the MasterGrid will be filled with the following number.</param>
        public ClsMasterGrid(int pRow, int pCol, int pNumber)
        {
            m_colMapSquare = new List<ClsMapSquare>();
            m_tabMap = new int[pRow, pCol];

            for (int row = 0; row < m_tabMap.GetLength(0); row++)
            {
                for (int col = 0; col < m_tabMap.GetLength(1); col++)
                {
                    m_tabMap[row, col] = pNumber;
                }
            }
        }
        /// <summary>
        /// Returns the content of the square specified.
        /// </summary>
        /// <param name="pRow">Row of the square wanted.</param>
        /// <param name="pCol">Column of the square wanted.</param>
        /// <returns>The content of the square at Row,Col.</returns>
        public int SquareAt(int pRow, int pCol)
        {
            return m_tabMap[pRow, pCol];
        }

        public int[,] Map
        {
            get
            {
                return m_tabMap;
            }
        }
    }
}
