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


        }
    }
}
