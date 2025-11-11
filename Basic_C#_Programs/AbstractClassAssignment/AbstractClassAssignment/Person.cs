using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    public abstract class Person
    {
        //Create two properties: FirstName and LastName
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Create an abstract method called SayName()
        public abstract void SayName();
    }
}
