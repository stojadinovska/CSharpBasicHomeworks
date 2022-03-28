using System;
using System.Globalization;

namespace AgeCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your birth date in format dd/mm/yyyy!");
            string birthDateInput = Console.ReadLine();
            DateTime birthDate = DateTime.Parse(birthDateInput, new CultureInfo("fr-FR", false));

            int AgeCalculator(DateTime date)
            {
                DateTime curentDate = DateTime.Now;
                int age = curentDate.Year - date.Year;
                if (birthDate > curentDate.AddYears(-age))
                    age--;
                return age;
            };

            Console.WriteLine(AgeCalculator(birthDate));
        }
    }
}
