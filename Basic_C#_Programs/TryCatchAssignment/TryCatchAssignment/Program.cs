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
                Console.WriteLine("Press enter to exit...");                
            }
            //Exception handling of the try catch block displaying error messages when
            //incorrect inputs are used
            catch (FormatException)
            {
                Console.WriteLine("Must enter whole numbers only...");
                return;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }                 
        }
    }
}
