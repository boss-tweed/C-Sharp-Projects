using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {    
            //Asks for user input to do math operations
            Console.WriteLine("Please select a number with which to perform the math operations on");
            int input = Convert.ToInt32(Console.ReadLine());
            
            
            //Call each method in Integer class and display result
            int divided = Integer.Divide(input);
            double times = Integer.Times(input);
            int minus = Integer.Minus(input);

            Console.WriteLine("Input: " + input);
            Console.WriteLine("Divide (value / 3): " + divided);
            Console.WriteLine("Times (value * 36.5): " + times);
            Console.WriteLine("Minus (value - 20): " + minus);

            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }
    }
}
