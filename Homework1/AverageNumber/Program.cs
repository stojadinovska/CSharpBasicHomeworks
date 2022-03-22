using System;

namespace AverageNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool firstNumBool = false;
            int firstNumber = default;

            Console.WriteLine("Enter the first number");
            while (!firstNumBool)
            {
                firstNumBool = int.TryParse(Console.ReadLine(), out firstNumber);
                if (!firstNumBool)
                    Console.WriteLine("Enter valid first number");
            }

            bool secondNumBool = false;
            int secondNumber = default;

            Console.WriteLine("Enter the second number");
            while (!secondNumBool)
            {
                secondNumBool = int.TryParse(Console.ReadLine(), out secondNumber);
                if (!secondNumBool)
                    Console.WriteLine("Enter valid second number");
            }

            bool thirdNumBool = false;
            int thirdNumber = default;

            Console.WriteLine("Enter the third number");
            while (!thirdNumBool)
            {
                thirdNumBool = int.TryParse(Console.ReadLine(), out thirdNumber);
                if (!thirdNumBool)
                    Console.WriteLine("Enter valid third number");
            }

            bool fourthNumBool = false;
            int fourthNumber = default;

            Console.WriteLine("Enter the fourth number");
            while (!fourthNumBool)
            {
                fourthNumBool = int.TryParse(Console.ReadLine(), out fourthNumber);
                if (!fourthNumBool)
                    Console.WriteLine("Enter valid fourth number");
            }

            Console.WriteLine($"The average of {firstNumber}, {secondNumber}, {thirdNumber} and {fourthNumber} is {(firstNumber + secondNumber + thirdNumber + fourthNumber) / 2}");
        }
    }
}
