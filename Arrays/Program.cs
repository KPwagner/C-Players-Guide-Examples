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

            // 2. Using foreach to find the total and average of an array's values

            // Declares sumArray with integer values
            int[] sumArray = new int[] { 20, 25, 30, 50, 55, 60, 100, 200 };

            // The variable total will be used to update the sum of the array
            int total = 0;

            foreach (int num in sumArray) 
            {
                total += num;
            }

            // Calculates the average of the values
            float average = (float)total / sumArray.Length;

            // Prints the values, sum, and average
            Console.Write("\n\n\nValues from sumArray are: ");
            foreach (int num in sumArray)
            {
                Console.Write($"{num} ");
            }

            Console.WriteLine($"\nThe sum of values in sumArray are {total}. The average of values in sumArray is {average}.");
        }
    }
}
