using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declares a variable as an integer.
            int score;
            // Assigns a value to the score variable.
            score = 0;
            // Declares and assigns a value in a single line.
            int theMeaningOfLife = 42;
            // Prints the value of the score variable to the console.
            Console.WriteLine(score);
            Console.ReadKey();
            Console.WriteLine(theMeaningOfLife);
            Console.ReadKey();

            // Declares and assigns value to two variables (a and b)
            int a = 5;
            int b = 2;
            // Reassigns values to variables b and a.
            // What will there values be after this assignment?
            b = a;
            a = -3;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.ReadKey();
        }
    }
}
