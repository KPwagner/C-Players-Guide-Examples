/*
    This program was created by Kyle Wagner.
    Anyone may use all or a part of this code without permission.
*/

using System;
namespace MakingClasses
{
    public class Color
    {
        // Sets up the Color class variables
        private ushort red;
        private ushort green;
        private ushort blue;
        private ushort alpha;

        // Color constructor with red, green, and blue ranges of 0-255, and default alpha value of 255
        public Color(ushort red, ushort green, ushort blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = 255;
        }

        // Color constructor with red, green, blue, and alpha ranges of 0-255
        public Color(ushort red, ushort green, ushort blue, ushort alpha)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = 255;
        }

        // 4 getter methods, one for each of the 4 color values
        public ushort GetRed()
        {
            return red;
        }

        public ushort GetGreen()
        {
            return green;
        }

        public ushort GetBlue()
        {
            return blue;
        }

        public ushort GetAlpha()
        {
            return alpha;
        }

        // 4 setter methods, one for each of the 4 color values
        public void SetRed(ushort red)
        {
            this.red = red;
        }

        public void SetGreen(ushort green)
        {
            this.green = green;
        }

        public void SetBlue(ushort blue)
        {
            this.blue= blue;
        }

        public void SetAlpha(ushort alpha)
        {
            this.alpha = alpha;
        }

        // Gets the grayscale value of the color
        public ushort GetGrayscale()
        {
            ushort colorAverage = (ushort)((red + green + blue) / 3);
            return colorAverage;
        }
    }
}
