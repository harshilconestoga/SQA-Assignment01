using System;
using System.Collections.Generic;
using System.Text;

namespace Rectangle_Area_Calculator
{
    public class Rectangle
    {
        private int length, width;

        public Rectangle() // Default constructor
        {
            length = 1;
            width = 1;
        }

        public Rectangle(int length, int width) // Non-default constructor
        {
            this.length = length;
            this.width = width;
        }

        public int GetLength()
        {
            return length;
        }

        public int SetLength(int length)
        {
            this.length = length;
            return length;
        }

        public int GetWidth()
        {
            return width;
        }

        public int SetWidth(int width)
        {
            this.width = width;
            return width;
        }

        public int GetPerimeter()
        {
            return 2 * (length + width); // Return perimeter
        }

        public int GetArea()
        {
            return (length * width); // Return Area
        }
    }
}
