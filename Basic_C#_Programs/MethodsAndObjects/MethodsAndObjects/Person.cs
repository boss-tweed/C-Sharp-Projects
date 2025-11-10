using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    public class Person
    {
        // Create properties for FirstName and LastName
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void SayName()
        {
            //Create a method called SayName that prints the person's full name to the console
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }
    }
}
