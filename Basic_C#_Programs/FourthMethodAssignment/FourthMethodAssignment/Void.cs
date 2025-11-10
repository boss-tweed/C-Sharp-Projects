using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthMethodAssignment
{
    internal class Void
    {
        public void VoidMethod(int num1, int num2)
        {
            //Math op performed on first parameter
            int sum = num1 * 10;

            //Display 2nd parameter to the screen
            Console.WriteLine("The second number is: " + num2);
        }
    }
}
