using System;

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
       
            Console.ReadLine();
        }
    }
}
