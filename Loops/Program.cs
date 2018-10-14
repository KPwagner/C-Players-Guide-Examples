/*
    This program was created by Kyle Wagner while working through The C# Player's Guide (R.B. Whitaker).
    Anyone may use all or part of this program without permission.
*/
using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                1. Print-a-Pyramid

                The challenge is to print the following pattern while using only one "*" character in the code:
                    *
                   ***
                  *****
                 *******
                *********
            */

            // Outermost for loop to iterate over the rows
            for (int row = 0; row < 5; row++)
            {
                // Prints spaces before the * character(s)
                for (int spaces = 4; spaces - row > 0; spaces--)
                {
                    Console.Write(" ");
                }

                // Prints an increasing number of * characters with each iteration of the row for loop
                for (int star = 1; star + row * 2 > 0 ; star--)
                {
                    Console.Write("*");
                }

                // Starts new line
                Console.WriteLine();
            }

            /*
                2. FizzBuzz

                The challenge is to print out all number from 1 to 100 with the following exceptions:
                1) If the number is divisible by 3, print "Fizz" instead of the number.
                2) If the number is divisible by 5, print "Buzz" instead.
                3) If the number is divisbible by 3 and 5, print "FizzBuzz".
            */

            // Loops through number 1 to 100
            for (int num = 1; num < 101; num++)
            {
                // Checks if remainder is 0 when dividing number by 3
                if (num % 3 == 0)
                {
                    // Checks if remainder is 0 when dividing number by 5
                    if (num % 5 == 0)
                    {
                        Console.WriteLine("FizzBuzz");
                    }
                    // Else is necessary so only one line is written
                    else
                    {
                        Console.WriteLine("Fizz");
                    }
                }
                else if (num % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                // If the number is not evenly divisible by 3 or 5, the number is prints
                else 
                {
                    Console.WriteLine(num);
                }
            }
        }
    }
}
