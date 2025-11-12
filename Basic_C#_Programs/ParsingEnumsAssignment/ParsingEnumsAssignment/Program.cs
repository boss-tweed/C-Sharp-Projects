using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnumsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate class
            EnumsExp example = new EnumsExp();

            //Try/catch block to handle exceptions
            bool success = false;
            while (!success)
            {
                try
                {
                    //Prompt user to enter current a day of the week
                    Console.WriteLine("Please enter the current day of the week:");

                    //Get user input and parsae enum
                    string dayInput = Console.ReadLine();

                    //Parse input of enum using TryParse
                    EnumsExp.DaysOfWeek currentDay;
                    if (Enum.TryParse<EnumsExp.DaysOfWeek>(dayInput, true, out currentDay)
                        && Enum.IsDefined(typeof(EnumsExp.DaysOfWeek), currentDay))
                    {
                        Console.WriteLine($"You have entered: {currentDay} ({(int)currentDay})");
                        success = true;
                    }
                    else
                    {
                        throw new ArgumentException();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter an actual day of the week"); ;
                }
            }
        }
    }
}
