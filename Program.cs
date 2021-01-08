using System;

namespace InneUkeDesember2020
{
    class Program
    {

        static void Main(string[] args)
        {
            var draw = new Rectangle("\u2592", 1, 3, 5, 16, ConsoleColor.Magenta);



            do
            {
                 int dX = 0;
                 int dY = 0;

                Console.Clear();
                draw.Show();
                var keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.LeftArrow) draw.Move(dX++, dY++);
                else if (keyInfo.Key == ConsoleKey.RightArrow) draw.Move(dX++, dY++);
                else if (keyInfo.Key == ConsoleKey.UpArrow) draw.Move(dX++, dY++);
                else if (keyInfo.Key == ConsoleKey.DownArrow) draw.Move(dX++, dY++);
            } while (true);
            //var userinput = Console.ReadKey();
            //Console.Write(userinput);
            
            


        }
    }
}
