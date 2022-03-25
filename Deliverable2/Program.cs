using System;

namespace Deliverable2
{
    class Program
    {
        public static void Run()
        {
            double rate = 9.99;
            int max = 6;
            string drink1 = ("water");
            string drink2 = ("coffee");

            Console.WriteLine("Hi. Welcome to our Buffet.");
            Console.WriteLine("All you can eat for $" + rate + "!");
            Console.WriteLine("We only charge extra for coffee.");
            Console.WriteLine();
            Console.WriteLine("How many people are in your group? Please, parties of " + max + " or lower.");

            var input1 = Console.ReadLine();
            if (int.TryParse(input1, out int party)) {
                if (party <= max && party > 0) {
                    int patron = (party - party) + 1;
                    Console.WriteLine();
                    Console.WriteLine("A table for " + party + "!");
                    Console.WriteLine("Let's get everyone started with some drinks. We've got " + drink1 + " or " + drink2 + ".");
                    Console.WriteLine();
                    while (party <= max && party > 0 && patron <= party)
                    {
                        Console.WriteLine("Alright, person number " + patron++ + ", OK!!!!!!!!!!!");
                    }
                    /* Console.WriteLine("Alright, person number " + party + ", " + drink1 + " or " + drink2 + "?"); */
                    /* try to condense so it automates each person # rather than typing all of them out */
                    string drinkChoice = Console.ReadLine();
                    if (drinkChoice == drink1 || drinkChoice == drink2)
                    {
                        Console.WriteLine(drinkChoice + ", good choice!");
                    }
                    else
                    {
                        Console.WriteLine("We don't have that. No drink for you!");
                    }
                    /* You need to store every patron's answer. Get to that later. */
                    double totalFood = party * rate;
                    double totalPrice = totalFood + 2;
                    Console.WriteLine();
                    Console.WriteLine("Here's your bill! Total price: $" + totalPrice + ". Sorry I ignored everyone in your party. The drinks are free until I wake up tomorrow and figure out the rest of this project.");
                } else if (party == 0) {
                    Console.WriteLine();
                    Console.WriteLine("Don't mess with me. You're here. There is no zero. Let's try again.");
                    Console.WriteLine();
                    Run();
                } else {
                    Console.WriteLine();
                    Console.WriteLine("TOO MANY. Let's try again.");
                    Console.WriteLine();
                    Run();
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("That makes no sense. I don't get paid enough for this. You're lucky I'll ask again...");
                Console.WriteLine();
                Run();
            }
        }
        static void Main(string[] args)
        {
            Run();
        }
        
    }
}