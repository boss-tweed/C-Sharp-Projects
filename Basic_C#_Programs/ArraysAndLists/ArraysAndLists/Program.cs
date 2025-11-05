using System;
using System.Collections.Generic;

    
class Program
{
    static void Main()
    {
        //One-dimensional array of strings w/ user input to select an index of said array
        string[] stringArray = new string[] { "Wicket", "Dog", "Boss", "Tweed", "Software", "Developer" };
        Console.WriteLine("Select an index number between 0 and 5 to display a word from the array");

        int selectIndex = Convert.ToInt32(Console.ReadLine());

        //Message displayed if  index selected does not exist
        if (selectIndex < 0 || selectIndex > 5)
        {
            Console.WriteLine("The index you selected does not exist in the array.");
        }
        else
        {
            Console.WriteLine("The word at index " + selectIndex + " is: " + stringArray[selectIndex]);
        }

        Console.ReadLine();

        //One-dimensional array of integers w/ user input to select an index of said array
        int[] intArray = new int[] { 37, 88, 19, 04, 11, 13 };
        Console.WriteLine("Select an index number between 0 and 5 to display a number from the array");

        int selectIntIndex = Convert.ToInt32(Console.ReadLine());

        //Message displayed if index selected does not exist
        if (selectIntIndex < 0 || selectIntIndex > 5)
        {
            Console.WriteLine("The index you selected does not exist in the array.");
        }
        else
        {
            Console.WriteLine("The number at index " + selectIntIndex + " is: " + intArray[selectIntIndex]);
        }

        //List of strings w/ user input to select an index of said list and display it
        List<string> stringList = new List<string>();
        stringList.Add("Bank");
        stringList.Add("Balance");
        stringList.Add("Deposit");
        stringList.Add("Withdraw");
        stringList.Add("Checking");
        stringList.Add("Savings");

        Console.WriteLine("Select an index number between 0 and 5 to display a word from the list");

        int selectListIdx = Convert.ToInt32(Console.ReadLine());

        //Message displayed for index selected
        Console.WriteLine("The word at index " + selectListIdx + " is: " + stringList[selectListIdx]);


        //THE FOLLOWING CODE ARE EXAMPLES FROM THE VIDEO SERIES FOR REFERENCE AND
        //NOT PART OF THE ASSIGNMENT ABOVE

        //List<string> intList = new List<string>();
        //intList.Add("Hello");
        //intList.Add("Garrett");


        //Console.WriteLine(intList[1]);
        //Console.ReadLine();

        //byte[] byteArray = new byte[300];

        //int[] numArray = new int[5];
        //numArray[0] = 5;
        //numArray[1] = 2;
        //numArray[2] = 10;
        //numArray[3] = 200;
        //numArray[4] = 5000;

        //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000, 600, 2300 };

        //int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 };

        //numArray2[5] = 650;

        //Console.WriteLine(numArray2[5]);
        //Console.ReadLine();
    }
}

