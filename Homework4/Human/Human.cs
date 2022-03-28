using System;
using System.Collections.Generic;
using System.Text;

namespace Human
{
    public class Human
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Age { get; private set; }

        public Human(string first, string last, string age)
        {
            FirstName = first;
            LastName = last;
            Age = age;
        }
        public string GetPersonStats()
        {
            return FirstName + " " + LastName + ", " + "age " + Age;
        }
    }
}
