using System;

namespace SwapNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            bool firstNumBool = false;
            int numberA = default;

            bool secondNumBool = false;
            int numberB = default;

            while (!firstNumBool)
            {
                firstNumBool = int.TryParse(Console.ReadLine(), out numberA);
                if (!firstNumBool)
                    Console.WriteLine("Enter valid first number");
            }
            Console.WriteLine("Enter the second number");
            while (!secondNumBool)
            {
                secondNumBool = int.TryParse(Console.ReadLine(), out numberB);
                if (!secondNumBool) Console.WriteLine("Enter valid second number");
            }

            Console.WriteLine($"Before swap the first number is {numberA} and the second number is {numberB}");
                numberA = numberA + numberB;     
                numberB = numberA - numberB;    
                numberA = numberA - numberB;    
            Console.Write($"After swap first number is {numberA} and the second number is {numberB}");
        }
    }
}
