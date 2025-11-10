using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    internal static class DivideMethod
    {
        public static void OutputInt(int value)
        {
            //Create a void method that outputs an integer and divide
            //the data passed to it by 2
            int sum = value / 2;

            Console.WriteLine("The output of the called method is: " + sum);
        }

        //Create a method w/ output parameters
        public static int OutputInt2(int value, out int result)
        {
            result = value * 45;
            return result;
        }

        public static double OutputInt2(double value)
        {
            double result = value * 13.75;
            return result;

        }
    }
}
