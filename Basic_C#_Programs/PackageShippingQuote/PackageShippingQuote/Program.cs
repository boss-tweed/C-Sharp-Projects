using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageShippingQuote
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below to get a shipping quote.");

            //User input for package weight
            Console.WriteLine("Please enter the package weight:");
            int weight = Convert.ToInt32(Console.ReadLine());

            //If else statement to check weight limit
            if (weight >= 51)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");                
                return;
            }
            else
            {
                Console.WriteLine("Thank you! Please continue to enter the dimensions");              
            }

            //User input for package dimensions
            Console.WriteLine("Please enter the package width:");
            int width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package height:");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package length:");
            int length = Convert.ToInt32(Console.ReadLine());

            //Calculate total dimensions
            int dimensions = width + height + length;

            //If else statement to check dimension limit and calculate quote
            if (dimensions <= 50)
            {
                double quote = (width * height * length * weight) / 100.00;
                Console.WriteLine("Your esitmated total for shipping this package is: $" + quote);                
            }
            else
            {
                Console.WriteLine("Package is too big to be shipped via Package Express.");                
            }
        }
    }
}
