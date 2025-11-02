using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousIncomeComparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables
            double a, b;
            int x, y, z;
            bool c;

            z = 52;
            

            //User input for Person 1
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();

            Console.WriteLine("Person 1");
            Console.Write("Enter amount for hourly rate: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter hours worked per week: ");
            x = Convert.ToInt32(Console.ReadLine());

            //Calculation for annual salary 1
            double annualSalary1 = a * x * z;

            Console.WriteLine("Annual salary of Person 1: " + annualSalary1);

            //User input for Person 2
            Console.WriteLine("Person 2");
            Console.Write("Enter amount for hourly rate: ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter hours worked per week: ");
            y = Convert.ToInt32(Console.ReadLine());

            //Calculation for annual salary 2
            double annualSalary2 = b * y * z;       

            Console.WriteLine("Annual salary of Person 2: " + annualSalary2);

            //Comparison
            c = annualSalary1 > annualSalary2;

            Console.WriteLine("Does Person 1 make more money than Person 2? " + c);
            Console.ReadLine();
        }
    }
}
