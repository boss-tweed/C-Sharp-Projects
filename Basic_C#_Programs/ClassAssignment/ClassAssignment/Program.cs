using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //This class was instantiated to call the methods in DivideMethod class.
            //But later on per assignment, I made the DivideMethod class static so instantiation is not necessary

            //User enters a number to call the DivideMethod on it
            Console.WriteLine("Please enter a number the method will divide with:");
            string intOut = Console.ReadLine();

            if (int.TryParse(intOut, out int val))
            {
                DivideMethod.OutputInt(val);
            }

            //User input to call the 2nd method w/ output parameter
            Console.WriteLine("Enter another number to call the second method with output parameter:");
            int intOut2 = Convert.ToInt32(Console.ReadLine());

            int result;
            DivideMethod.OutputInt2(intOut2, out result);
            Console.WriteLine("The output of the second method is: " + result);

            //User input to call the overloaded method
            Console.WriteLine("Enter a decimal number to call the overloaded method:");
            double doubleOut = Convert.ToDouble(Console.ReadLine());

            double overloadResult = DivideMethod.OutputInt2(doubleOut);
            Console.WriteLine("The output of the overloaded method is: " + overloadResult);
        }   
    }
}
