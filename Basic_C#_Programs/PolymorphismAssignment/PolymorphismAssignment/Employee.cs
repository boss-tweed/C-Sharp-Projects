using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
     public class Employee : IQuittable
    {
        //Inheriting the interface method and implementing it
        public void Quit()
        {
            Console.WriteLine("Employee has quit.");
        }
    }
}
