using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class Walls
    {
        List<Figure> wallList;

        public Walls (int mapWight, int mapHight)
        {
            wallList = new List<Figure>();

            //Отрисовка рамок
            HorizontalLine upLine = new HorizontalLine(0, mapWight - 2, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, mapWight - 2, mapHight -1, '+');
            VerticalLine leftLine = new VerticalLine(0, mapHight - 1, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, mapHight - 1, mapWight - 2, '+');

            wallList.Add(upLine);
            wallList.Add(downLine);
            wallList.Add(leftLine);
            wallList.Add(rightLine);
        }

        internal bool IsHit(Figure figure)
        {
            foreach(var wall in wallList)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }
        public void Draw()
        {
            foreach (var wall in wallList)
            {
                wall.Draw();
            }
        }
    }
}
