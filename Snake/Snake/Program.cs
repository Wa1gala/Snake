using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80,25);
            Console.SetBufferSize(80,25);

            //Рамка
            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');
            VerticalLine leftLine = new VerticalLine(0, 24, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, 24, 78, '+');
            upLine.Drow();
            downLine.Drow();
            leftLine.Drow();
            rightLine.Drow();

            //Точки
            Point p2 = new Point(4, 5, '*');
            p2.Drow();
           
            Console.ReadLine();
        }
    }
}
