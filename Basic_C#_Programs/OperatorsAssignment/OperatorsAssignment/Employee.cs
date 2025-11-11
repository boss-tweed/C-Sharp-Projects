using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    public class Employee
    {
        //Create 3 properties: ID, FirstName, LastName
        public int ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        //Overload the == operator to compare two Employee objects.
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            if (ReferenceEquals(emp1, emp2)) return true;
            if (ReferenceEquals(emp1, null) || ReferenceEquals(emp2, null)) return false;
            return emp1.ID == emp2.ID;
        }

        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return !(emp1.ID == emp2.ID);
        }
    }
}
