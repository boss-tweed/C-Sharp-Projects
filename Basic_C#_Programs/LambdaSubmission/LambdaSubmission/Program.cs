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

            //Create a list of at least 10 employees.
            List<string> employees  = new List<string>() { "Joe James", "Joe Jack", "Garrett Fisher", "Delaney Rose", "Jordan Glen", "Shannon Kate", "Gary Daniel", "Sandra Jean", "Jim Jacobs", "Janet Fina" };

            //foreach loop creates a new list of all employees w/ the first name Joe.
            List<string> joeEmployees = new List<string>();
            foreach (string emp in employees) // Renamed loop variable to 'emp' to avoid CS0136
            {
                if (string.Equals(emp, "Joe", StringComparison.OrdinalIgnoreCase))
                {
                    joeEmployees.Add(emp);
                }
            }

            //Perform the same action w/ a Lambda expression
            List<string> joEmployees = employees
                .Where(e => string.Equals(e, "Joe", StringComparison.OrdinalIgnoreCase))
                .ToList();

            //Lambda expression w/ list of employees w/
            //an ID number greater than 5
            List<string> idEmployees = employees
                .Where((e, index) => index > 5)
                .ToList();
        }
    }
}
