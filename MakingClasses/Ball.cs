using System;
namespace MakingClasses
{
    public class Ball
    {
        private int size;
        private Color color;
        private int numThrows;

        // Basic constructor requiring only size, and defaulting numThrows to 0
        public Ball(int size)
        {
            this.size = size;
            this.numThrows = 0;
        }

        // Constructor requiring size and a color object (color class defined elsewhere in this solution)
        public Ball(int size, Color color)
        {
            this.size = size;
            this.color = color;
            this.numThrows = 0;
        }

        // Pop method changes the size of the ball to 0
        public void Pop()
        {
            this.size = 0;
        }

        // Throw method add one to numThrows
        public void Throw()
        {
            if(this.size != 0)
            {
                this.numThrows += 1;
            }
        }

        // Getter methods
        public int GetSize()
        {
            return this.size;
        }

        public int GetThrows()
        {
            return this.numThrows;
        }
    }
}
