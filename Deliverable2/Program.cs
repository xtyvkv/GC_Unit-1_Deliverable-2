using System;

namespace Deliverable2
{
    class Program
    {
        public static void Run()
        {
            double rate = 9.99;
            int max = 6;

            Console.WriteLine("Hi. Welcome to our Buffet.");
            Console.WriteLine("All you can eat for $" + rate + "!");
            Console.WriteLine("We only charge extra for coffee.");
            Console.WriteLine();
            Console.WriteLine("How many people are in your group? Please, parties of " + max + " or lower.");

            var input = Console.ReadLine();
            if (int.TryParse(input, out int party)) {
                if (party <= max && party > 0) {
                    Console.WriteLine("A table for " + party + "!");
                } else if (party == 0) {
                    Console.WriteLine("Don't mess with me. You're here. There is no zero.");
                } else {
                    Console.WriteLine("TOO MANY");
                }
            }
            else
            {
                Console.WriteLine("That makes no sense. I don't get paid enough for this.");
            }
        }
        static void Main(string[] args)
        {
            Run();
        }
        
    }
}
