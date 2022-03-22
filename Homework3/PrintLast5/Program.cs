using System;
using System.Linq;

namespace PrintLast5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your string");
            string myString = Console.ReadLine();
            Console.WriteLine(myString[Math.Max(0, myString.Length - 5)..]);
        }
    }
}
