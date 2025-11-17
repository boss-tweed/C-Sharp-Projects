using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorSubmission
{
    public class Studious
    {
        //Create a constant variable and a variable w/ the var keyword
        private const string message = "Hey there!";

        //constructor w/ no parameter that calls the constructor w/ one parameter
        public Studious() : this(1988)
        {
        }

        //Chained constructor w/ one parameter receiving a value
        public Studious(int year)
        {
            //var can only be used locally
            var localYear = year;
            string chainedValues = $"{message} You are studying in the year {localYear}.";
            Console.WriteLine(chainedValues);
        }
    }
}
