﻿using System;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point();
            p1.x = 3;
            p1.y = 5;
            p1.sym = '#';

            p1.Drow();

            Point p2 = new Point();
            p2.x = 6;
            p2.y = 8;
            p2.sym = '*';

            p2.Drow();
       
            Console.ReadLine();
        }
    }
}
