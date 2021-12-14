#define XFrench
using System;

namespace Day_1._5_cont_starting_FizzBuzz
{
    class Program
    {
       

        static void Main(string[] args)
        {
            // Console.WriteLine("False. Bears. Beets. Battlestar Galactica.");
            //{ for (var idx = 1; idx <= 30; idx++) { Console.Write($"FizzBuzz ")};
            //  if (idx % 3 == 0) { Console.Write("Fizz")} else; 
            //if (idx % 5 == 0) { Console.Write("Buzz")} else;
            //{ Console.Write("{idx}")};
            //}

            var yes = "Yes";
            var no = "No";
#if French
            var yes = "Oui";
            var no = "Non";
#endif
            var boolean = true;
            Console.WriteLine($"Boolean is {boolean}; text is {(boolean ? yes : no)}");


        }
    }
}
