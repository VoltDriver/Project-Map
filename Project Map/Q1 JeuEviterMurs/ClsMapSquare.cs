using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Project_Map
{
    /// <summary>
    /// Represents a square. It has coordinates and a content.
    /// </summary>
    public class ClsMapSquare
    {
        private Size coordinates;
        private int content;
        /// <summary>
        /// Creates a square Item, which has coordinates and a content (int)
        /// </summary>
        /// <param name="pRow">Row of the square.</param>
        /// <param name="pCol">Column of the square.</param>
        /// <param name="pContent">Number contained in the square.</param>
        public ClsMapSquare(int pRow, int pCol, int pContent)
        {
            coordinates = new Size(pRow, pCol);
            content = pContent;
        }

        public int Row
        {
            get
            {
                return coordinates.Height;
            }
        }
        public int Col
        {
            get
            {
                return coordinates.Width;
            }
        }

        public int Content
        {
            get
            {
                return content;
            }
            set
            {
                content = value;
            }
        }
    }
}
