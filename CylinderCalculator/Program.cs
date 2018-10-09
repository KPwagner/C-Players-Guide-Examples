using System;

namespace CylinderCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            This program takes cylinder radius and height input from a user, then outputs the volume and surface area.
            */

            // Declares and assigns the variable pi the approximate value of 3.1415926
            float pi = 3.1415926f;

            // Welcome message
            Console.WriteLine("Welcome to Cylinder Calculator." +
                              "\nJust follow the instructions, " +
                              "and you will get the volume and surface area of your cylinder.");

            // Requests cylinder radius from user
            Console.WriteLine("\n\nWhat is the radius of the cylinder?");
            string whatUserTyped = Console.ReadLine();

            // Converts radius string to float
            float cylinderRadius = Convert.ToSingle(whatUserTyped);

            // Requests cylinder height from user
            Console.WriteLine("\nWhat is the height of the cylinder?");
            whatUserTyped = Console.ReadLine();

            // Converts height string to float
            float cylinderHeight = Convert.ToSingle(whatUserTyped);

            // Calculates the volume and surface area of the cylinder based on standard formulas
            float cylinderVolume = pi * cylinderRadius * cylinderRadius * cylinderHeight;
            float cylinderSurfaceArea = 2 * pi * cylinderRadius * (cylinderRadius + cylinderHeight);

            // Prints out the volume and surface
            Console.WriteLine($"\nThe volume of the cylinder is {cylinderVolume} cubic units.");
            Console.WriteLine($"\nThe surface area of the cylinder is {cylinderSurfaceArea} square units.");
        }
    }
}
