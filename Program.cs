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
                Console.Clear();
                draw.Show();
                var keyInfo = Console.ReadKey();

            } while (true);
            //var userinput = Console.ReadKey();
            //Console.Write(userinput);
            
            


        }
    }
}
