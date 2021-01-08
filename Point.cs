using System;
using System.Collections.Generic;
using System.Text;

namespace InneUkeDesember2020
{
    class Point
    {
        private int dX;
        private int dY;

        public Point(int dx, int dy)
        {
            dX = dx;
            dY = dy;
        }

        public static Point PointFromKey(ConsoleKeyInfo keyInfo)
        {
            var p = new Point(0, 0);
            if (keyInfo.Key == ConsoleKey.LeftArrow) p.dX--;
            else if (keyInfo.Key == ConsoleKey.RightArrow) p.dX++;
            else if (keyInfo.Key == ConsoleKey.UpArrow) p.dX--;
            else if (keyInfo.Key == ConsoleKey.DownArrow) p.dY++;

            return p;
        }
    }
}
