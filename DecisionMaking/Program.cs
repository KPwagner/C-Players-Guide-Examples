/*
This program was created by Kyle Wagner while working through The C# Player's Guide (R.B. Whitaker)
Anyone is free to use, copy, or modify part or all of this program without my permission.
*/

using System;

namespace DecisionMaking
{
    class Program
    {
        static void Main(string[] args)
        {
            // Welcome message for Even/Odd program
            Console.WriteLine("Welcome to Even/Odd, where you can determine if a number is even or odd.");

            // Gets a number from the user
            Console.WriteLine("\nPlease enter an integer number:");
            string intAsText = Console.ReadLine();
            int userNumber = Convert.ToInt32(intAsText);

            // Sets up the bool value for the conditional
            bool evenNumber = userNumber % 2 == 0;

            // Check the bool value and produces the even or odd output
            if (evenNumber)
            {
                Console.WriteLine("\nThe number is even.");
            }
            else 
            {
                Console.WriteLine("\nThe number is odd.");
            }

            // Welcome message for Positive/Negative program
            Console.WriteLine("\n\n\nWelcome to Positive/Negative. Enter two integer numbers, and I'll tell you if the product is positive or negative.");

            // Gets the first number from the user
            Console.WriteLine("\nPlease enter the first integer:");
            intAsText = Console.ReadLine();
            int firstNumber = Convert.ToInt32(intAsText);

            // Gets the second number from the user
            Console.WriteLine("\nPlease enter the second integer:");
            intAsText = Console.ReadLine();
            int secondNumber = Convert.ToInt32(intAsText);

            // Checks if both numbers are positive or both are negative
            // Returns "even" if true and "odd" if false
            string evenOdd = "";
            if ((firstNumber > 0 && secondNumber > 0) || (firstNumber < 0 && secondNumber < 0))
            {
                evenOdd = "even";
            }
            else
            {
                evenOdd = "odd";
            }
            Console.WriteLine($"\nThe product of those two numbers is {evenOdd}.");
        }
    }
}
