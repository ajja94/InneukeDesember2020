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
        private ConsoleColor _consoleColor;

        public Rectangle(string rectanglething, int position1, int position2, int heigth, int width, ConsoleColor consoleColor)
        {
            _rectanglething = rectanglething;
            _position1 = position1;
            _position2 = position2;
            _heigth = heigth;
            _width = width;
            _consoleColor = consoleColor;
        }

        public void Show()
        {
            DrawRectangle(_position1, _position2, ConsoleColor.Green);
 
            //Console.SetCursorPosition(_position1, _position2);
        }

        public void DrawRectangle(int _position1, int _position2, ConsoleColor consoleColor)
        {
            Console.CursorLeft = _position1;
            Console.CursorTop = _position2;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(_rectanglething);
        }
    }
}
