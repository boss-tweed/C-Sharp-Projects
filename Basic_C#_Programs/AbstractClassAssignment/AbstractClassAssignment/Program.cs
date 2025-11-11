using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Instantiate an Employee object with first and last name
            Employee employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";

            //Call the SayName method on the Employee object
            employee.SayName();
        }
    }
}
