using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool succeeded = false;

            while (!succeeded)
            {
                //try/catch block
                try
                {
                    //List of integers where user inputs a number that divides each integer
                    //in the list and outputs to the console
                    List<int> toDivideBy = new List<int>() { 84, 66, 52, 98, 107, 121, 243 };

                    Console.WriteLine("Please enter a number for which list of intergers will divide by");
                    int divisor = Convert.ToInt32(Console.ReadLine());

                    for (int i = 0; i < toDivideBy.Count; i++)
                    {
                        int result = (int)toDivideBy[i] / divisor;
                        Console.WriteLine($"{toDivideBy[i]} / {divisor} = {result}");
                    }
                    //So loop can exit
                    succeeded = true;   
                }

                //Exception handling of the try catch block displaying error messages when
                //incorrect inputs are used
                catch (FormatException)
                {
                    Console.WriteLine("Must enter whole numbers only...");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.WriteLine("Program has succesfully executed after exception handling");
            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }
    }
}
