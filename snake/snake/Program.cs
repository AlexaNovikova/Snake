using System;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 3;
            int y1 = 5;
            char symbol1 = '#';
            Draw(x1, y1, symbol1);
            int x2 = 10;
            int y2 = 12;
            char symbol2 = '%';
            Draw(x2, y2, symbol2);

            Console.ReadLine();
        }
        static void Draw (int x, int y, char symbol)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);
        }
    }
}
