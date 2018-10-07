using System;

namespace BasicMath
{
    class Program
    {
        static void Main(string[] args)
        {
            // Using basic math operators and variables to calculate the area of two triangles.
            float b = 5f;
            float h = 6f;
            float area = (1f / 2f) * b * h;
            Console.WriteLine("The base of the triagle is " + b + ", the height of the triangle is " + h + ", and the area of the triangle is " + area + ".");

            b = 1.5f;
            h = 4f;
            area = (1f / 2f) * b * h;
            Console.WriteLine("The base of the triagle is " + b + ", the height of the triangle is " + h + ", and the area of the triangle is " + area + ".");

            // Using the % operator to calculate remainders.
            int x = 17;
            int y = 4;
            int quotient = x / y; // Since quotient is an int variable, x/y rounds down to the nearest integar
            int remainder = x % y;
            Console.WriteLine(x + "/" + y + " is " + quotient + " remainder " + remainder);

            x = 45;
            y = 3;
            quotient = x / y;
            remainder = x % y;
            Console.WriteLine(x + "/" + y + " is " + quotient + " remainder " + remainder);

            x = 447;
            y = 23;
            quotient = x / y;
            remainder = x % y;
            Console.WriteLine(x + "/" + y + " is " + quotient + " remainder " + remainder);
        }
    }
}
