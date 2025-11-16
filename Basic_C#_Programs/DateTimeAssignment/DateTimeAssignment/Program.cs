using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Prints current date and time to the console using DateTime value type
            DateTime currentTime = DateTime.Now;
            Console.WriteLine("The current date and time is: " + currentTime);

            //Ask for user input in the form of an intger
            Console.WriteLine("Please enter an integer into the console:");
            int userInput = Convert.ToInt32(Console.ReadLine());

            //Prints to console the exact time it will in X hours, X being the intger the user
            //inputed plus the current time
            DateTime futureTime = currentTime.AddHours(userInput);
            Console.WriteLine("The current date/time plus " + userInput + " hours is: " + futureTime);
        }
    }
}
