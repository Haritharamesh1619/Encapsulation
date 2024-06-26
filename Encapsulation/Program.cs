using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
     class Program
    {
        static void Main()
        {
            // Create a new Person object

            Person p1 = new Person

            // Initializes the p1 object's properties using an object initializer.
            {
                FirstName = "John",
                LastName = "Doe",
                Age = 30
            };

            // Display person's 1 information

            p1.DisplayInfo();// call the method to display person's full information

            // Create another Person object

            Person p2 = new Person
            {
                FirstName = "Jane",
                LastName = "Smith",
                Age = -5 // This should trigger the validation and set age to 0
            };

            // Display person's 2 information

            p2.DisplayInfo(); // call the method to display person's full information

            Console.ReadLine(); // Pause to view the output
        }
    }
}

