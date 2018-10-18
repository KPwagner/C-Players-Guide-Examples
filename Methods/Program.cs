/*
    This program was created by Kyle Wagner.
    Any or all contents may be used without permission.
*/

using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calling methods from section 1 (reversing an array)
            int[] numbers = GenerateNumbers();
            Console.WriteLine("Here is an array with 10 integar values:");
            PrintNumbers(numbers);
            numbers = Reverse(numbers);
            Console.WriteLine("After reversing the contents of the array, the values look like this:");
            PrintNumbers(numbers);

            // Calling Fibonacci method from section 2
            Console.WriteLine("\n\n");
            Console.WriteLine($"The Fibonacci number at position 3 of the Fibonacci sequence is {Fibonacci(3)}.");
            Console.WriteLine($"The Fibonacci number at position 7 of the Fibonacci sequence is {Fibonacci(7)}.");
            Console.WriteLine($"The Fibonacci number at position 21 of the Fibonacci sequence is {Fibonacci(21)}.");
        }
        /*
            1. Reversing an Array
            The challenge is to create an array with 10 elements, reverse the contents of the array, then print the resulting elements.
            This must be accomplished by creating 3 methods.
        */

        // GenerateNumbers method takes no input and returns an array of 10 numbers
        static int[] GenerateNumbers()
        {
            return new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        }

        // Reverse method takes an array as input and returns another array with each element in reverse order from the original array
        static int[] Reverse(int[] beforeArray)
        {
            // Declares the empty array that will be returned
            int[] afterArray = new int[10];
            for (int i = 0; i < 10; i++)
            {
                // Reverses the order by assigning the last elements from beforeArray to the first elements of afterArray
                afterArray[i] = beforeArray[beforeArray.Length - 1 - i];
            }
            return afterArray;
        }

        // PrintNumbers method takes an array as input and prints out each element
        static void PrintNumbers(int[] printArray)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write(printArray[i] + " ");
            }
            Console.WriteLine();
        }

        /*
            2. The Fibonacci Squence
            The challenge is to use a recursive method to return the value at a given position in the Fibonacci sequence.
        */
        /// <summary>
        /// Fibonacci the specified position.
        /// </summary>
        /// <returns>Fibonacci value</returns>
        /// <param name="position">Fibonacci position</param>
        static int Fibonacci(int position)
        {
            if (position == 1 || position == 2)
            {
                return 1;
            }

            return Fibonacci(position - 1) + Fibonacci(position - 2);
        }
    }
}
