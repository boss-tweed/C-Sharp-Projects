using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();

            //Create a list of at least 10 employees. Two of which has the first name "Joe"
            List<Employee> employees  = new List<Employee>() 
            { 
                new Employee { ID = 0, FirstName = "Joe", LastName = "Jack" },
                new Employee { ID = 1, FirstName = "Joe", LastName = "James" },
                new Employee { ID = 2, FirstName = "Garrett", LastName = "Fisher" },
                new Employee { ID = 3, FirstName = "Jordan", LastName = "Glen" },
                new Employee { ID = 4, FirstName = "Shannon", LastName = "Kate" },
                new Employee { ID = 5, FirstName = "Gary", LastName = "Daniel" },
                new Employee { ID = 6, FirstName = "Sandra", LastName = "Jean" },
                new Employee { ID = 7, FirstName = "Janet", LastName = "Bliss" },
                new Employee { ID = 8, FirstName = "Jim", LastName = "Jones" },
                new Employee { ID = 9, FirstName = "Delaney", LastName = "Rose" }
            };

            //foreach loop creates a new list of all employees w/ the first name Joe.
            List<Employee> joeEmployees = new List<Employee>();
            foreach (Employee emp in employees) // Renamed loop variable to 'emp' to avoid CS0136
            {
                //Reference the FirstName property of the Employee object using a string comparison method
                if (string.Equals(emp.FirstName, "Joe", StringComparison.OrdinalIgnoreCase))
                {
                    joeEmployees.Add(emp);
                }
            }

            //Perform the same action w/ a LINQ + Lambda expression
            List<Employee> joEmployees = employees
                .Where(e => string.Equals(e.FirstName, "Joe", StringComparison.OrdinalIgnoreCase))
                .ToList();

            //Lambda expression w/ list of employees w/
            //an ID number greater than 5
            List<Employee> idEmployees = employees
                .Where(e => e.ID > 5)
                .ToList();
        }
    }
}
