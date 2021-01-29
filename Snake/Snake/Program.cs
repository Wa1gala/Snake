using System;
using System.Collections.Generic;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(3, 5, '#');
            p1.Drow();

            Point p2 = new Point(6, 8, '*');
            p2.Drow();

            List<int> numList = new List<int>();
            numList.Add(0);
            numList.Add(1);
            numList.Add(2);

            int x = numList[0];
            int y = numList[1];
            int z = numList[2];

            foreach (int i in numList )
            {
                Console.WriteLine(i);
            }

            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);

            Console.ReadLine();
        }
    }
}
