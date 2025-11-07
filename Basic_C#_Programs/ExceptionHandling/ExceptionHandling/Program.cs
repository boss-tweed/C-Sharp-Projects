using System;


class Program
{
    static void Main(string[] args)
    {
        bool succeeded = false;

        while (!succeeded)
        {
            try
            {
                Console.WriteLine("Pick a number");
                int numberOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Pick a second number");
                int numberTwo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Dividing the two...");
                int numberThree = numberOne / numberTwo;
                Console.WriteLine(numberOne + " divided by " + numberTwo + " = " + numberThree);

                //So loop can exit
                succeeded = true;
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Please use any whole number other than 0");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //Message to user that exception handling was successful aand program continued
        Console.WriteLine("Execution has continued after exception handling");
        Console.WriteLine("Press Enter to exit...");
        Console.ReadLine();       
    }
}