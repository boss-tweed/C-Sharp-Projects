using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthMethodAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instantiating the Void class. Calls the method in the class,
            //passing in 2 numbers. Calls the method in the class specifying parameter names,
            Void voidInstn = new Void();
            voidInstn.VoidMethod(10, 25);
            voidInstn.VoidMethod(num1: 15, num2: 5);

            Console.WriteLine(voidInstn);
        }
    }
}
