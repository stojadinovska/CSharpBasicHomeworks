using System;

namespace SumOfEven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] integerArray = new int[6];
            int result = 0;

            for(int i = 0; i < integerArray.Length; i++)
            {
                Console.WriteLine($"Enter integer no. {i + 1}");
                if(int.TryParse(Console.ReadLine(), out integerArray[i]))
                {
                    if(integerArray[i] % 2 == 0)
                    {
                        result += integerArray[i];
                    }
                }

                else
                {
                    Console.WriteLine($"Input is not valid!");
                    i--;
                }

            }

            Console.WriteLine($"The result is:{result}");

        }
    }
}
