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
            /* declare the drink choice variables here?? */

            Console.WriteLine("Hi. Welcome to our Buffet.");
            Console.WriteLine("All you can eat for $" + rate + "!");
            Console.WriteLine("We only charge extra for coffee.");
            Console.WriteLine();
            Console.WriteLine("How many people are in your group? Please, parties of " + max + " or lower.");

            string input1 = Console.ReadLine();
            if (int.TryParse(input1, out int party)) {
                if (party <= max && party > 0) {
                    int patron = (party - party) + 1;
                    Console.WriteLine();
                    Console.WriteLine("A table for " + party + "!");
                    Console.WriteLine("Let's get everyone started with some drinks. We've got " + drink1 + " or " + drink2 + ".");
                    Console.WriteLine();
                    do
                    {
                        Console.WriteLine("Alright, person number " + patron++ + ", " + drink1 + " or " + drink2 + "?");
                        string drinkChoice = Console.ReadLine().ToLower();
                        if (drinkChoice == drink1)
                        {
                            if (drinkChoice.Length == 0)
                                Console.WriteLine("Empty String");
                            /* figure out where to take that "empty string" business */
                            /* do i need the else if AND else below? */
                            /* what if they don't want drinks? - low priority */
                            else
                                Console.WriteLine(char.ToUpper(drinkChoice[0]) + drinkChoice.Substring(1) + ", good choice!");
                            int drinkNumber;
                            Int32.TryParse(drinkChoice, out drinkNumber);
                            Console.WriteLine((drinkNumber + 1) + "!");
                            Console.WriteLine();
                        }
                        else if (drinkChoice == drink2)
                        {
                            if (drinkChoice.Length == 0)
                                Console.WriteLine("Empty String");
                            else
                                Console.WriteLine(char.ToUpper(drinkChoice[0]) + drinkChoice.Substring(1) + ", okay!");
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("We don't have that. No drink for you!");
                            Console.WriteLine();
                        }
                        /* for (int drinkNumber = 0; drinkNumber++)
                        {
                            Console.WriteLine(drinkNumber + "waters.");
                        } 
                        */
                    } while (party <= max && party > 0 && patron <= party);
                    /* TEST */
                    Console.WriteLine("Okay, so that's " + "__" + drink2 + "s and " + "__" + drink1 + "s.");
                    /* make singular or plural depending on # */
                    Console.WriteLine("I'll be right back. Feel free to grab your food!");
                    /* END TEST */
                    /* Figure out how to store all possible responses in order to calculate bill. */
                    /* Assign prices to the 2 drinks */
                    double totalFood = party * rate;
                    double totalPrice = totalFood + 2;
                    Console.WriteLine();
                    Console.WriteLine("Here's your bill! Total price: $" + totalPrice + ".");
                } else if (party == 0) {
                    Console.WriteLine();
                    Console.WriteLine("Don't mess with me. You're here. There is no zero. Let's try again.");
                    Console.WriteLine();
                    Run();
                } else {
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