using System;
using System.Collections.Generic;
using System.Text;

namespace InneUkeDesember2020
{
    class Point
    {
        public int dX;
        public int dY;

        public Point(int dx, int dy)
        {
            dX = dx;
            dY = dy;
        }

        public static Point PointFromKey(ConsoleKeyInfo keyInfo)
        {
            var p = new Point(0, 0);
            if (keyInfo.Key == ConsoleKey.LeftArrow) p = new Point(-1, 0);
            else if (keyInfo.Key == ConsoleKey.RightArrow) p = new Point(1, 0);
            else if (keyInfo.Key == ConsoleKey.UpArrow) p = new Point(0, -1);
            else if (keyInfo.Key == ConsoleKey.DownArrow) p = new Point(0, 1);

            return p;
        }
    }
}
