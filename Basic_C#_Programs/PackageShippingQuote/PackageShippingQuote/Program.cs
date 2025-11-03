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
            Console.ReadLine();

            Console.WriteLine("Please enter the package weight:");
            int weight = Convert.ToInt32(Console.ReadLine());

            if (weight >= 51)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                return;
            }
            else
            {
                Console.WriteLine("Thank you! Please continue to enter the dimensions");
                Console.ReadLine();
            }

            Console.WriteLine("Please enter the package width:");
            int width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package height:");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package length:");
            int length = Convert.ToInt32(Console.ReadLine());

            int dimensions = width + height + length;

            if (dimensions <= 50)
            {
                double quote = (width * height * length * weight) / 100.00;
                Console.WriteLine("Your esitmated total for shipping this package is: $" + quote);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Package is too big to be shipped via Package Express.");
                Console.ReadLine();
            }
        }
    }
}
