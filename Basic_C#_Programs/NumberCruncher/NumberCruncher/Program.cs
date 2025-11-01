using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberCruncher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, z, c;
            double a;
            bool b;
            char operation;

            //User input "x"
            Console.Write("Enter first number (x): ");
            x = Convert.ToInt32(Console.ReadLine());

            //User input for operation to perform (*, +, /, >, %)
            Console.Write("Enter operation (*, +, /, >, %): ");
            operation = Convert.ToChar(Console.ReadLine());

            //Variables for (y, z, a, b, c)
            y = 50;
            z = 25;
            a = 12.5;
            b = x > 50;
            c = 7;


            //Conditional statements for operation
                if (operation == '*')
                {
                    Console.WriteLine("Result: " + (x * y));
                }
                else if (operation == '+')
                {
                    Console.WriteLine("Result: " + (x + x));
                }
                else if (operation == '/')
                {
                    Console.WriteLine("Result: " + (x / a));
                }
                else if (operation == '>')
                {
                    Console.WriteLine("Result: " + b);
                }
                else if (operation == '%')
                {
                    Console.WriteLine("Result: " + (x % c));
                }
                else
                { Console.WriteLine("Invalid operation."); }
        }
    }
}
