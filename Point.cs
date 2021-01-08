using System;
using System.Collections.Generic;
using System.Text;

namespace InneUkeDesember2020
{
    class Point
    {
        int dX = 0;
        int dY = 0;

        public  Point PointFromKey(ConsoleKeyInfo keyInfo)
        {
            if (keyInfo.Key == ConsoleKey.LeftArrow) dX--;
            else if (keyInfo.Key == ConsoleKey.RightArrow) dX++;
            else if (keyInfo.Key == ConsoleKey.UpArrow) dY--;
            else if (keyInfo.Key == ConsoleKey.DownArrow) dY++;

            return Point;
        }
    }
}
