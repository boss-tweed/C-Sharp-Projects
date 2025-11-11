using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    //Create a class Employee that inherits from the Person class
    public class Employee : Person
    {
        //Implement the SayName() method to display the employee's full name
        public override void SayName()
        {
            // Display the full name
            Console.WriteLine($"Employee Name: {FirstName} {LastName}");
        }
    }
}
