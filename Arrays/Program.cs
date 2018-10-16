/*
    This program created by Kyle Wagner while working through The C# Player's Guide (R.B. Whitaker).
    All or any part of this program may be used without permission.
*/

using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Copying an Array

            // Declares initial array with integer values
            int[] firstArray = new int[] { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };

            // Declares second empty array for copied contents
            int[] secondArray = new int[10];

            for (int index = 0; index < firstArray.Length; index++)
            {
                // Copies that values at each index from the initial array to the second array
                secondArray[index] = firstArray[index];
            }

            // Prints the values of the initial array
            Console.Write("Values from the inital array: ");
            for (int index = 0; index < firstArray.Length; index++)
            {
                Console.Write($"{firstArray[index]} ");
            }

            // Prints the copied values of the second array to check that they are the same
            Console.Write("\nValues from the second array: ");
            for (int index = 0; index < secondArray.Length; index++)
            {
                Console.Write($"{secondArray[index]} ");
            }

        }
    }
}
