using System;

namespace SumOfDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number biger than 9");
            string number = Console.ReadLine();

            static int SumOfDigits(string num)
            {
                int result = 0;

                foreach (char c in num)
                {
                    result += int.Parse(c.ToString());
                }

                return result;
            }

            Console.WriteLine(SumOfDigits(number));
        }
    }
}
