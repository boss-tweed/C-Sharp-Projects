using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsuranceApproval
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables
            int age;
            int speedingTickets;
            bool hasDUI;
            
            Console.WriteLine("Welcome to the Car Insurance Approval Program!");
            Console.ReadLine();

            //User input for age, speeding tickets, and DUI
            Console.WriteLine("What is yourg age? ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many speeding tickets do you have? ");
            speedingTickets = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI? Please answer true or false ");
            hasDUI = Convert.ToBoolean(Console.ReadLine());

            //Approval condition
            bool isApproved = (age >= 15) && (speedingTickets <= 3) && (hasDUI == false);

            Console.WriteLine("Qualified? " + isApproved);
        }
    }
}
