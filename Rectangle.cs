using System;
using System.Collections.Generic;
using System.Text;

namespace InneUkeDesember2020
{
    class Rectangle
    {
        private string _rectanglething;

        public Rectangle(string rectanglething)
        {
            _rectanglething = rectanglething;
        }

        public void Show()
        {
            Console.WriteLine(_rectanglething);
        }
    }
}
