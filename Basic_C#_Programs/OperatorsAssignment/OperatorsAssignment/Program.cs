using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiat two Employee objects
            Employee emp1 = new Employee() { ID = 1, FirstName = "Garrett", LastName = "Fisher" };
            Employee emp2 = new Employee() { ID = 2, FirstName = "Indica", LastName = "Marie" };

            //compare the two objects using the overloaded == operator and display the result
            bool areEqual = emp1 == emp2;
            bool areNotEqual = emp1 != emp2;

            Console.WriteLine($"Are emp1 and emp2 equal? {areEqual}");
            Console.WriteLine($"Are emp1 and emp2 not equal? {areNotEqual}");
        }
    }
}
