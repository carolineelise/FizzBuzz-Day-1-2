using System;

namespace Day_1._5_cont_starting_FizzBuzz
{
    class Program
    {
        private static int idx;

        static void Main(string[] args)
        {
            Console.WriteLine("False. Bears. Beets. Battlestar Galactica.");
            for (var idx = 1; idx <= 30; idx++) { Console.Write($"FizzBuzz ")};
            else if (idx % 3 == 0) { Console.Write("Fizz")};
            else if (idx % 5 == 0) { Console.Write("Buzz")};
                else {  Console.Write("{idx}")};


        }
    }
}
