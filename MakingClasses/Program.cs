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
        }
    }
}
