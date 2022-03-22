using System;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");

            int.TryParse(Console.ReadLine(), out int enterdNumber);

            for(int i = 1; i <= enterdNumber; i++)
            {
                if(i % 5 == 0)
                {
                    continue;
                }

                if(i > 80)
                {
                    break;
                }

                Console.WriteLine(i);
            }
        }
    }
}
