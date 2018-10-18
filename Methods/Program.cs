using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = GenerateNumbers();
            Console.WriteLine("Here is an array with 10 integar values:");
            PrintNumbers(numbers);
            numbers = Reverse(numbers);
            Console.WriteLine("After reversing the contents of the array, the values look like this:");
            PrintNumbers(numbers);
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
            int[] afterArray = new int[10];
            for (int i = 0; i < 10; i++)
            {
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


    }
}
