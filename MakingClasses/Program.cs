/*
    This program was created by Kyle Wagner.
    Anyone may use all or a part of this code without permission.
*/

using System;

namespace MakingClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            // Running some code using the Color class

            // Creating the Color purple
            Color purple = new Color(128, 0, 128);
            Console.WriteLine($"The color purple:" +
                              $"\nRED\t\t{purple.GetRed()}" +
                              $"\nGREEN\t\t{purple.GetGreen()}" +
                              $"\nBLUE\t\t{purple.GetBlue()}" +
                              $"\nALPHA\t\t{purple.GetAlpha()}" +
                              $"\nGRAYSCALE\t{purple.GetGrayscale()}");

            purple.SetAlpha(150);
            Console.WriteLine("\n\nI just changed the alpha value of purple.");
            Console.WriteLine($"The color purple:" +
                              $"\nRED\t\t{purple.GetRed()}" +
                              $"\nGREEN\t\t{purple.GetGreen()}" +
                              $"\nBLUE\t\t{purple.GetBlue()}" +
                              $"\nALPHA\t\t{purple.GetAlpha()}" +
                              $"\nGRAYSCALE\t{purple.GetGrayscale()}");

            // Running some code using the Ball class

            // Creating a Ball object
            Ball purpleBall = new Ball(14, purple);
            Console.WriteLine($"\n\nThe ball purpleBall looks like this:" +
                              $"\nSIZE\t\t{purpleBall.GetSize()}" +
                              $"\nTHROWS\t\t{purpleBall.GetThrows()}");

            purpleBall.Throw();
            purpleBall.Throw();
            purpleBall.Pop();
            purpleBall.Throw();

            Console.WriteLine($"\nAfter throwing purpleBall a few times then poping it, it looks like this:" +
                              $"\nSIZE\t\t{purpleBall.GetSize()}" +
                              $"\nTHROWS\t\t{purpleBall.GetThrows()}");

            // Creating another ball object
            Ball redBall = new Ball(16, new Color(255, 0, 0));
            Console.WriteLine($"\n\nThe ball redBall looks like this:" +
                              $"\nSIZE\t\t{redBall.GetSize()}" +
                              $"\nTHROWS\t\t{redBall.GetThrows()}");

            redBall.Throw();
            for (int i = 0; i < 4; i++)
            {
                redBall.Throw();
            }

            Console.WriteLine($"\nAfter throwing redBall a few times, it looks like this:" +
                              $"\nSIZE\t\t{redBall.GetSize()}" +
                              $"\nTHROWS\t\t{redBall.GetThrows()}");

            // Running some code using the Stapler class

            // Creating a Stapler object
            Stapler purpleStapler = new Stapler(47, 100, purple);

            // Printing the purpleStapler properties, except color
            // Not sure how to get the color value (red, green, blue, alpha, and grayscale)
            Console.WriteLine($"\n\nThe stapler purpleStapler looks like this:" +
                              $"\nSTAPLE CAPACITY\t{purpleStapler.StapleCapacity}" +
                              $"\nSTAPLES\t\t{purpleStapler.Staples}");
        }
    }
}
