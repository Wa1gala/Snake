using System;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 1;
            int y1 = 4;
            char sym1 = '*';

            Drow(x1, y1, sym1);

            int x2 = 4;
            int y2 = 5;
            char sym2 = '#';

            Drow(x2,y2,sym2);

            Console.ReadLine();
        }
        static void Drow(int x, int y, char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
