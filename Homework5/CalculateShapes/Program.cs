using System;

namespace CalculateShapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle newRec = new Rectangle("Red", "Rectangle", new int[2] {20, 20}, 12, 12);
            newRec.GetPerimeter();
            newRec.GetArea();

            Console.WriteLine("--------------------------------");

            Rectangle otherRec = new Rectangle("Blue", "Rectangle", new int[2] { 18, 12 }, 15, 15);
            otherRec.GetPerimeter();
            otherRec.GetArea();

            Console.WriteLine("--------------------------------");

            Circle newCircle = new Circle("White", "Circle", new int[2] { 1, 2 }, 5);
            newCircle.GetPerimeter();
            newCircle.GetArea();

            Console.WriteLine("--------------------------------");

            Circle otherCircle = new Circle("Black", "Circle", new int[2] { 8, 16 }, 9);
            newCircle.GetPerimeter();
            newCircle.GetArea();
        }
    }
}
