using System;
using System.Collections.Generic;
using System.Text;

namespace CalculateShapes
{
    internal class Rectangle : Shape
    {
        public int SideA;
        public int SideB;

        public Rectangle(string color, string name, int[] pos, int a, int b)
        {
            Color = color;
            Name = name;
            Position = pos;
            SideA = a;
            SideB = b;
        }

        public override void GetArea()
        {
            Console.WriteLine("Area: " + SideA * SideB);
        }

        public override void GetPerimeter()
        {
            Console.WriteLine("Perimeter: " + SideA + SideB);
        }
    }
}
