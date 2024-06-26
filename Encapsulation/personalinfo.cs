using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    // Define the Person class
    public class Person
    {
        // Private fields
        private string firstName;
        private string lastName;
        private int age;

        // Public properties to get and set private fields
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public int Age
        {
            get { return age; }
            set
            {
                // Validate age to ensure it is non-negative
                if (value >= 0)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("Age cannot be negative. Setting age to 0.");
                    age = 0;
                }
            }
        }

        // Method to display person's full information
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {FirstName} {LastName},Age: {Age}");
        }
    }
}
