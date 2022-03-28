using System;
using System.Collections.Generic;
using System.Text;

namespace CalculateShapes
{
    internal class Circle : Shape
    {
        public int Radius;

        public Circle(string color, string name, int[] pos, int rad)
        {
            Color = color;
            Name = name;
            Position = pos;
            Radius = rad;
        }

        public override void GetArea()
        {
            Console.WriteLine("Area: " + Math.PI * (Radius * Radius));
        }

        public override void GetPerimeter()
        {
            Console.WriteLine("Perimeter " + 2 * Math.PI * Radius);
        }
    }
}
