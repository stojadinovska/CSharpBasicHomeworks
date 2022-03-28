using System;

namespace Human
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human someHuman = new Human(ReadInput("first name"), ReadInput("last name"), ReadInput("age")) ;

            Console.WriteLine(someHuman.GetPersonStats());
     
            string ReadInput(string input)
            {
                Console.WriteLine("Enter " + input);
                return Console.ReadLine();

            }
        }
    }


}
