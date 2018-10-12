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
            for (int row = 1; row < 6; row++)
            {
                // Prints spaces before the * character(s)
                for (int spaces = 0; spaces < 5 - row; spaces++)
                {
                    Console.Write(" ");
                }

                // Prints a fixed number of * characters
                for (int column = 0; column < 2 * row - 1 ; column++)
                {
                    Console.Write("*");
                }

                // Starts new line
                Console.WriteLine();
            }


        }
    }
}
