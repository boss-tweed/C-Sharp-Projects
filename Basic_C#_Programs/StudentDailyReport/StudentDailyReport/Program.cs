using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDailyReport
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Student daily report app
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");

            // Ask the user questions and store their responses
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("Hello " + yourName + "!");

            Console.WriteLine("What course are you on?");
            string yourCourse = Console.ReadLine();
            Console.WriteLine("And what step are you on?");
            // Convert the string input to an integer and store response
            int yourStep = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You are currently on step " + yourStep + " of the " + yourCourse + " course. Congrats on your hard work!");

            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            // Convert the string input to a boolean and store response
            bool requireHelp = Convert.ToBoolean(Console.ReadLine());
            // If/else statement based on boolean response
            if (requireHelp)
            {
                Console.WriteLine("An instructor will reach out to you shortly. Thank you!");
            }
            else
            {
                Console.WriteLine("Awesome! Keep up the good work!");
            }

            // Ask for positive experiences and to share added feedback
            Console.WriteLine("Please share any positive experiences you have had so far. Please give specifics.");
            string positiveExp = Console.ReadLine();
            Console.WriteLine("Any other feedback you wish to provide? Please be specific.");
            string addedFeedback = Console.ReadLine();
            Console.WriteLine("Thank you for sharing your experiences and feedback!");

            // Ask for hours study and store reponse converted from an integer
            Console.WriteLine("How many hours did you study today?");
            int studyHours = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Great job for studying " + studyHours + " hours today!");

            Console.WriteLine("Thank you for your answers. An instructor will respond shortly. Have a great day!");
        }
    }
}
