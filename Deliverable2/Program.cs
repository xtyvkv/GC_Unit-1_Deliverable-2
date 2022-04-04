using System;

namespace Deliverable2
{
    class Program
    {
        public static void Run()
        {
            int max = 6;
            string freeDrink = ("water");
            string premiumDrink = ("coffee");
            int freeDrinkCount = 0;
            int premiumDrinkCount = 0;
            double premiumDrinkRate = 2;
            double buffetRate = 9.99;

            Console.WriteLine("Hi. Welcome to our Buffet.");
            Console.WriteLine("All you can eat for $" + buffetRate + "!");
            Console.WriteLine("We only charge extra for coffee.");
            Console.WriteLine();
            Console.WriteLine("How many people are in your group? Please, parties of " + max + " or lower.");

            string input1 = Console.ReadLine();
            if (int.TryParse(input1, out int party)) 
            {
                if (party <= max && party > 0) 
                {
                    int patron = (party - party) + 1;
                    Console.WriteLine();
                    Console.WriteLine("A table for " + party + "!");
                    Console.WriteLine("Let's get everyone started with some drinks. We've got " + freeDrink + " or " + premiumDrink + ".");
                    Console.WriteLine();
                    do 
                    {
                        Console.WriteLine("Alright, person number " + patron++ + ", " + freeDrink + " or " + premiumDrink + "?");
                        string drinkChoice = Console.ReadLine().ToLower();
                        if (drinkChoice == freeDrink) 
                        {
                                Console.WriteLine(char.ToUpper(drinkChoice[0]) + drinkChoice.Substring(1) + ", good choice!");
                                freeDrinkCount++;
                                Console.WriteLine();
                        } 
                        else if (drinkChoice == premiumDrink) 
                        {
                                Console.WriteLine(char.ToUpper(drinkChoice[0]) + drinkChoice.Substring(1) + ", okay!");
                                premiumDrinkCount++;
                                Console.WriteLine();
                        } 
                        else 
                        {
                            Console.WriteLine("We don't have that. No drink for you!");
                            Console.WriteLine();
                        }
                    } 
                    while (party <= max && party > 0 && patron <= party);
                    Console.WriteLine("Okay, so that's " + premiumDrinkCount + " " + premiumDrink + "(s) and " + freeDrinkCount + " " + freeDrink + "(s).");
                    Console.WriteLine("I'll be right back. Feel free to grab your food!");
                    double totalPrice = ((party * buffetRate) + (premiumDrinkCount * premiumDrinkRate));
                    Console.WriteLine();
                    Console.WriteLine("Here's your bill! Total price: $" + totalPrice + ".");
                } 
                else if (party == 0) 
                {
                    Console.WriteLine();
                    Console.WriteLine("Don't mess with me. You're here. There is no zero. Let's try again.");
                    Console.WriteLine();
                    Run();
                } 
                else 
                {
                    Console.WriteLine();
                    Console.WriteLine("Oh sorry, can only seat parties up to " + max + ". Have a nice day.");
                    Environment.Exit(0);
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