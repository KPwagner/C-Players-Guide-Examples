using System;

namespace MoreMath
{
    class Program
    {
        static void Main(string[] args)
        {
            // Testing out typecasting expressions
            double a = 1.0 + 1 + 1.0f;
            Console.WriteLine($"The expression 1.0 + 1 + 1.0f evaluates to {a} and has type of {a.GetType()}.");

            int x = (int)(7 + 3.0 / 4.0 * 2);
            Console.WriteLine($"\nThe expression (int)(7 + 3.0 / 4.0 * 2) evaluates to {x} and has a type of {x.GetType()}.");

            Console.WriteLine($"\nThe expression (1 + 1) / 2 * 3 evaluates to {(1 + 1) / 2 * 3} and has a type of {((1+1)/2*3).GetType()}.");

            // Looking at overflow and underflow
            short y = 30000;
            short b = 30000;
            // Explicit cast is necessary in this expression, so the result does not get converted to int
            short sum = (short)(y + b);
            Console.WriteLine($"\nA short variable with a value of 30,000 plus another short variable with a value of 30,000 will exceed the maximum value of a short ({short.MaxValue})." +
                              $"\nThe resulting sum in this case is {sum}." +
                              "\nThis phenomenon is called overflow and is the result of the sum value \"wrapping around\" the short range.");

            // When using the postfix increment operator (e.g. c++ or c--), the value of c before the incrementing is returned.
            int z = 3;
            Console.WriteLine($"\nThe int variable z was assigned the value of {z}.");
            z++;
            Console.WriteLine($"But after using the increment operator (z++) once, the value of z is now {z}.");

            // When using the prefix increment operator (e.g. ++c or --c), the value of c after the incrementing is returned.
            int c = 7;
            Console.WriteLine($"\nThe int variable c was assigned the value of {c}.");
            int d = --c;
            Console.WriteLine($"The int variable d was assigned the value of --c, and now the value of c is {c}, and the value of d is {d}.");
        }
    }
}
