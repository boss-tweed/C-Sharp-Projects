using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            bool success = false;
            while (!success)
            {
                try
                {
                    //Asks user input for their age
                    Console.WriteLine("Please enter how old you are:");
                    string currentAge = Console.ReadLine();

                    //Validates user input to ensure it is a positive integer
                    if (int.TryParse(currentAge, out int age))
                    {
                        if (age <= 0)
                            throw new ArgumentOutOfRangeException();
                    }

                    //Calculates birth year based on current year minus user age
                    int birthYear = DateTime.Now.Year - age;
                    Console.WriteLine("Based on the info provided, you were born in the year of {0}", birthYear);

                    success = true;
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
