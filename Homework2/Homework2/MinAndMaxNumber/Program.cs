using System;
using System.Linq;

namespace MinAndMaxNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] integerArray = { 12, -4, 8, 153, -49, 267, 64, 0, 45, 654};

            Console.WriteLine($"The minimum number is {integerArray.Min()}");
            Console.WriteLine($"The maximum number is {integerArray.Max()}");
        }
    }
}
