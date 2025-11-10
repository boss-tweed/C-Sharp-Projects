using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdMethodAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instantiate the class. Ask the user to input 2 numbers, one can be optional.
            //Call the method in the class, passing in the numbers, then display the result to the user.
            OptionalIntegers optionalIntegers = new OptionalIntegers();

            int numInput1;
           
            Console.WriteLine("Please enter the first number");
            if (int.TryParse(Console.ReadLine(), out numInput1))
                   
            Console.WriteLine("Please enter the second number (or press Enter to skip)");
            string secondLine = Console.ReadLine();

            int result;
            if (string.IsNullOrWhiteSpace(secondLine))
            {
                //Call method w/ only one paremter
                result = optionalIntegers.OptionalIntMethod(numInput1);
            }
            else if (int.TryParse(secondLine, out int numInput2))
            {
                //Call method w/ both parameters
                result = optionalIntegers.OptionalIntMethod(numInput1, numInput2);
            }
            else
            {
                Console.WriteLine("Invalid input for 2nd number. Using 0 as default");
                result = optionalIntegers.OptionalIntMethod(numInput1);
            }

            Console.WriteLine($"The result is: {result}");
        }
    }
}
