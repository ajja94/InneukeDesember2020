using System;

namespace InneUkeDesember2020
{
    class Program
    {
        static void Main(string[] args)
        {
            var draw = new Rectangle("\u2592", 13, 2, 5, 6);
            var userinput = Console.ReadKey();
            Console.WriteLine(userinput);
            draw.Show();
        }
    }
}
