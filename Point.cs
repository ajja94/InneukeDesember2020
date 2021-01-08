using System;
using System.Collections.Generic;
using System.Text;

namespace InneUkeDesember2020
{
    class Point
    {
        int dX = 0;
        int dY = 0;

        public Point(int dx, int dy)
        {
            dX = dx;
            dY = dy;
        }

        public static Point PointFromKey(ConsoleKeyInfo keyInfo)
        {
            if (keyInfo.Key == ConsoleKey.LeftArrow) dx--;
            else if (keyInfo.Key == ConsoleKey.RightArrow) dx++;
            else if (keyInfo.Key == ConsoleKey.UpArrow) dy--;
            else if (keyInfo.Key == ConsoleKey.DownArrow) dy++;

            return Point;
        }
    }
}
