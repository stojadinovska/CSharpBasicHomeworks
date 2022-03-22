using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter one of the operations +, -, *, /");
            string operations = Console.ReadLine();

            Console.WriteLine("Enter the first number");
            if (int.TryParse(Console.ReadLine(), out int firstNumber))
            {
                Console.WriteLine("Enter the second number");
                if (int.TryParse(Console.ReadLine(), out int secondNumber))
                {
                    Console.WriteLine(calculator(operations, firstNumber, secondNumber));
                }
                else Console.WriteLine("Invalid input");

            }
            else Console.WriteLine("Invalid input");

            static int calculator (string opr , int firstN, int secondN)
            {
                int result = 0;
                switch (opr)
                {
                    case "+":
                        result = firstN + secondN;
                        break;
                    case "-":
                        result = firstN - secondN;
                        break;
                    case "*":
                        result = firstN * secondN;
                        break;
                    case "/":
                        result = firstN / secondN;
                        break ;
                    default:
                        Console.WriteLine("Invalid operator");
                        break;
                }
                return result;
            }
        }
    }
}
