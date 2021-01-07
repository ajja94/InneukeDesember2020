using System;

namespace InneUkeDesember2020
{
    class Program
    {

        static void Main(string[] args)
        {
            var draw = new Rectangle("\u2592", 1, 3, 5, 6, ConsoleColor.Magenta);
            //var userinput = Console.ReadKey();
            //Console.Write(userinput);
            draw.Show();

        }
    }
}
