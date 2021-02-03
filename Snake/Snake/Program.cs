using System;
using System.Threading;
using System.Collections.Generic;


namespace Snake
{
    class Program
    {
        class Huy
        {
            //    VerticalLine vl = new VerticalLine(0, 10, 5, '%');
            //    Draw(vl);

            //    Point p = new Point(4, 5, '*');
            //    Figure fSnake = new Snake(p, 4, Direction.RIGHT);
            //    Draw(fSnake);
            //    Snake snake = (Snake)fSnake;

            //    HorizontalLine hl = new HorizontalLine(0, 5, 6, '&');

            //    List<Figure> figures = new List<Figure>();
            //    figures.Add(fSnake);
            //    figures.Add(vl);
            //    figures.Add(hl);

            //    foreach (var f in figures)
            //    {
            //        f.Draw();
            //    }
            //}

            //static void Draw (Figure figure)
            //{
            //    figure.Draw();
            //}
        }
        class Zalupa
        {
            //Рамка
            //HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
            //HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');
            //VerticalLine leftLine = new VerticalLine(0, 24, 0, '+');
            //VerticalLine rightLine = new VerticalLine(0, 24, 78, '+');
            //upLine.Drow();
            //downLine.Drow();
            //leftLine.Drow();
            //rightLine.Drow();

            //Точки
            //Point p = new Point(4, 5, '*');
            //Snake snake = new Snake(p, 4, Direction.RIGHT);
            //snake.Drow();

            //FoodCreator foodCreator = new FoodCreator(80, 25, '~');
            //Point food = foodCreator.CreateFood();
            //food.Draw();

            //while (true)
            //{
            //    if (snake.Eat(food))
            //    {
            //        food = foodCreator.CreateFood();
            //        food.Draw();
            //    }
            //    else
            //    {
            //        snake.Move();
            //    }

            //    Thread.Sleep(100);

            //    if (Console.KeyAvailable)
            //    {
            //        ConsoleKeyInfo key = Console.ReadKey();
            //        snake.HandleKey(key.Key);
            //    }               
            //}
        }
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);

            Walls walls = new Walls(80,25);
            walls.Draw();

            //Отрисовка точек
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }

                Thread.Sleep(100);
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
            } 
        }
    }
}
