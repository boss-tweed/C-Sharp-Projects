using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Create an object type of IQuittable
            IQuittable quittable = new Employee();

            //Interface reference to the object. Call the Quit() method on the object
            IQuittable emp = quittable;
            emp.Quit();

        }
    }
}
