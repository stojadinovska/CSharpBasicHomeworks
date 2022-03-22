using System;

namespace RealCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            bool firstBool = false;
            int firstNumber = default;

            bool secondBool = false;
            int secondNumber = default;

            string operation = "";

            while (!firstBool)
            {
                firstBool = int.TryParse(Console.ReadLine(), out firstNumber);
                if (!firstBool)
                    Console.WriteLine("Enter valid first number");
            }
            Console.WriteLine("Enter the second number");
            while (!secondBool)
            {
                secondBool = int.TryParse(Console.ReadLine(), out secondNumber);
                if (!secondBool) Console.WriteLine("Enter valid second number");
            }

            while (true)
            {
                Console.WriteLine("Enter operator +, -, / or *");
                operation = Console.ReadLine();
                if (operation == "+" || operation == "-" || operation == "/" || operation == "*") break;
            }

            switch (operation)
            {
                case "+":
                    Console.WriteLine($"The result is {firstNumber + secondNumber}");
                    break;
                case "-":
                    Console.WriteLine($"The result is {firstNumber - secondNumber}");
                    break;
                case "/":
                    Console.WriteLine($"The result is {firstNumber / secondNumber}");
                    break;
                case "*":
                    Console.WriteLine($"The result is {firstNumber / secondNumber}");
                    break;
                default:
                    Console.WriteLine("Enter valid operator");
                    break;
            }

        }
    }
}
