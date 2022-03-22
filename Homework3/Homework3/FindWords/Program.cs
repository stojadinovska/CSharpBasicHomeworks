using System;

namespace FindWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence with more than one word.");
            string sentence = Console.ReadLine();
            string[] splitedSentence = sentence.Split(' ');

            foreach (string s in splitedSentence)
            {
                Console.WriteLine(s);
            }

        }
    }
}
