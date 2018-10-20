/*
    This program was created by Kyle Wagner.
    Any part of this code may be used without permission.
*/
using System;

namespace ClassesObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                1. Die Rolling
                The challenge is to create a die rolling program.
                The program must get a number from the user, then output the resulting sum as though that many six-sided dice were rolled.
                The program should keep letting the user roll dice until they type "quit".
            */
            // Welcome message
            Console.WriteLine("Welcome to Die Roller. Type 'quit' to end the program.");

            // Forever loop; broken by the if statement, checking if the user typed "quit"
            while (true)
            {
                Console.WriteLine("Enter the number of six-sided dice you want to roll, and I will sum the results (type 'quit' to exit):");

                // Takes user input of a number
                string diceString = Console.ReadLine();
                if (diceString == "quit")
                {
                    break;
                }

                // Converts the string number to an integer
                int diceInt = Convert.ToInt32(diceString);
                int diceSum = 0;
                Random random = new Random();

                // Rolls a six-sided die and updates the cumulative result until not dice remain
                for (int i = 0; i < diceInt; i++)
                {
                    diceSum += random.Next(6) + 1;
                }

                // Prints the result
                Console.WriteLine($"\nThe sum is {diceSum}.\n\n");
            }
        }
    }
}
