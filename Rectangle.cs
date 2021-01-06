using System;
using System.Collections.Generic;
using System.Text;

namespace InneUkeDesember2020
{
    class Rectangle
    {
        private string _rectanglething;
        private int _position1;
        private int _position2;
        private int _heigth;
        private int _width;

        public Rectangle(string rectanglething, int position1, int position2, int heigth, int width)
        {
            _rectanglething = rectanglething;
            _position1 = position1;
            _position2 = position2;
            _heigth = heigth;
            _width = width;
        }

        public void Show()
        {
            Console.CursorTop = _position1;
            Console.CursorLeft = _position2;
            Console.WriteLine(_rectanglething);
            Console.SetCursorPosition(_position1, _position2);
        }

        public void DrawRectangle()
        {
            
        }
    }
}
