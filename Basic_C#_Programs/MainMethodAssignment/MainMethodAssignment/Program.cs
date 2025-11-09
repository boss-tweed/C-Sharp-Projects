using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instantiate the ThreeMethods class, call MethodOne and display to console
            ThreeMethods mathOps = new ThreeMethods();
            int number1 = mathOps.MethodOne(25);

            Console.WriteLine("MethodOne (input + 10): " + number1);

            //Instantiate ThreeMethods class to call overloaded MethodOne and display to console
            ThreeMethods mathOps2 = new ThreeMethods();
            int number2 = mathOps2.MethodOne(67.75m);

            Console.WriteLine("MethodOne (input * 20): " + number2);

            //Instantiate ThreeMethods class to call 3rd overloaded MethodOne and display to console
            ThreeMethods mathOps3 = new ThreeMethods();
            int number3 = mathOps3.MethodOne("175");

            Console.WriteLine("MethodOne (input - 75): " + number3);
        }
    }
}
