using System;

namespace HowMany
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of elements!");
            int numOfElements = int.Parse(Console.ReadLine());
            int[] integerArray = new int[numOfElements];
            int counter = 0;
            for(int i = 0; i < numOfElements; i++)
            {
                Console.WriteLine("Enter a number");
                integerArray[i] = int.Parse(Console.ReadLine());
            }
            for(int i = 0; i < integerArray.Length - 1; i++)
            {
                if(integerArray[i] == 3 && integerArray[i+1] == 3) 
                {
                    counter++;
                }
            }
            Console.WriteLine($"{counter} times there are threes next to each other");

        }
    }
}
