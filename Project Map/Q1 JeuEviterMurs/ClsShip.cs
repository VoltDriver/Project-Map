using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_Map
{
    /// <summary>
    /// Represents a ship, which has coordinates and possibly other stats.
    /// </summary>
    public class ClsShip
    {
        private int m_row;
        private int m_col;
        // 1 = left, 2 = Down, 3 = Right, 4 = Up. Facing.
        private int m_lastDirection;

        public ClsShip(int pRow, int pCol)
        {
            m_col = pCol;
            m_row = pRow;
        }

        public int Row
        {
            get
            {
                return m_row;
            }
            set
            {
                m_row = value;
            }
        }
        public int Col
        {
            get
            {
                return m_col;
            }
            set
            {
                m_col = value;
            }
        }
        public int LastDirection
        {
            get
            {
                return m_lastDirection;
            }
            set
            {
                m_lastDirection = value;
            }
        }
    }
}
