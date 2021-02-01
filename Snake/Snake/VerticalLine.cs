using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class VerticalLine : Figure
    {
        public VerticalLine(int ytop, int ydown, int x, char sym)
        {
            pList = new List<Point>();
            for (int y = ytop; y <= ydown; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }
    }
}
