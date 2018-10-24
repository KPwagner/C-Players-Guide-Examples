/*
    This program was created by Kyle Wagner.
    Anyone may use all or a part of this code without permission.
*/

using System;
namespace MakingClasses
{
    // This class (Stapler) is an example of properties usage in place of getter/setter methods (Chapter 19).
    public class Stapler
    {
        // Sets up the Staple class variables
        private Color color;
        private int staples;
        private int stapleCapacity;

        // Stapler class has two constructors, one with Color and one without
        public Stapler(int staples, int stapleCapacity)
        {
            this.staples = staples;
            this.stapleCapacity = stapleCapacity;
        }

        public Stapler(int staples, int stapleCapacity, Color color)
        {
            this.color = color;
            this.staples = staples;
            this.stapleCapacity = stapleCapacity;
        }

        // Creates a staples property with the get/set syntax
        public int Staples
        {
            get
            {
                return staples;
            }
            set
            {
                staples = value;
                if (staples < 0)
                    staples = 0;
            }
        }

        // Creates stapleCapacity with the get/set syntax
        public int StapleCapacity
        {
            get
            {
                return stapleCapacity;
            }
            set
            {
                stapleCapacity = value;
                // stapleCapacity defaults to 0 if the value is not in the range of 0 to 1000
                if (stapleCapacity < 0 || stapleCapacity > 1000)
                    stapleCapacity = 0;
            }
        }

        public Color Color
        {
            get
            {
                return color;
            }
        }
    }
}
