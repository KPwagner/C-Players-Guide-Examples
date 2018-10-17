using System;

namespace Enumerations
{
    // Creates an enumeration for the months of the year
    enum MonthsOfYear { January = 1, February = 2, March = 3, April = 4, May = 5, June = 6, July = 7, August = 8, September = 9, October = 10, November = 11, December = 12 };

    class Program
    {
        static void Main(string[] args)
        {
            // Gets month as a number from user
            Console.WriteLine("Please provide a number between 1 and 12 to represent a month.");
            string monthAsString = Console.ReadLine();

            // Converts to int and checks if the value is in the range 1-12
            int monthAsInt = Convert.ToInt32(monthAsString);
            if (monthAsInt > 0 && monthAsInt < 13)
            {
                // Explicit cast is required
                MonthsOfYear userMonth = (MonthsOfYear)monthAsInt;
                // The book states to use a switch or if statement to print the month's name.
                // I chose to not use either, as I can seemingly get the desired effect without either.
                Console.WriteLine($"\nYou entered the number {monthAsString}, which equals {userMonth}.");
            }
            else
            {
                Console.WriteLine($"\nSorry, that entry is not valid. Please rerun this program to try again.");
            }
        }
    }
}
