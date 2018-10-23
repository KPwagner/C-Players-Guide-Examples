using System;

namespace MakingClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            // Running some code from the Color class

            // Creating the color purple
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

            // Running some code from the Ball class

            // Creating a ball object
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
        }
    }
}
