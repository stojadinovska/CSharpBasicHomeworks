using System;

namespace FindStatistics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");

            int firstNumber = default;
            bool firstNumberBool = false;
            while (!firstNumberBool)
            {
            firstNumberBool = int.TryParse(Console.ReadLine(), out firstNumber);
            if (!firstNumberBool)
                Console.WriteLine("Enter valid first number");
            }

            Console.WriteLine("Enter the second number");

            int secondNumber = default;
            bool secondNumberBool = false;
            while (!secondNumberBool)
            {
                secondNumberBool = int.TryParse(Console.ReadLine(), out secondNumber);
                if (!secondNumberBool)
                    Console.WriteLine("Enter valid second number");
            }

            if(firstNumber % 2 == 0 && secondNumber % 2 == 0)
            {
                Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
            }
            else if (firstNumber % 2 != 0 && secondNumber % 2 != 0)
            {
                Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
            }
            else if (firstNumber % 2 != 0 || secondNumber % 2 != 0)
            {
                Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
            }
        }
    }
}
