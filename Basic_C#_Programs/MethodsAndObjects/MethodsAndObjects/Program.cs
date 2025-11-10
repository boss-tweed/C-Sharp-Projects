using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a new Employee object
            Employee employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";

            //Call the SayName method from the Person class
            employee.SayName();
        }
    }
}
