using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleAppIterateThroughArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //Part-1 of assignment
            //One dimensional array of strings
            string[] birthdates = { "11/04/1988", "05/04/1963", "12/08/1998", "04/04/1996", "02/08/1960" };

            //User input prompt
            Console.WriteLine("Please enter some text to ask about birthdates");
            string userInput = Console.ReadLine();

            //Loop that iterates through array and appends user input to each string but does not output to console
            foreach (string date in birthdates)
            {
                if (string.IsNullOrWhiteSpace(userInput))
                {
                    string result = userInput + " " + date;
                }

            }
            //Loop that prints off each string in array one at a time
            foreach (string date in birthdates)
            {
                Console.WriteLine(date);
            }
            Console.ReadLine();

            //Part-2 of assignment
            //Infinite loop of array
            bool exit = false;
            while (!exit)
            {
                foreach (string date in birthdates)
                {
                    Console.WriteLine(date);
                    Thread.Sleep(500); //Speed

                    //Able to execute stop to loop by pressing escape
                    if (Console.KeyAvailable && Console.ReadKey(intercept: true).Key == ConsoleKey.Escape)
                    {
                        Console.WriteLine("End of Loop");
                        exit = true;
                        break;
                    }
                }
            }

            //Part-3 of assignment
            //loop where the comparison that’s used to determine to continue iterating loop is < operator.
            for (int i = 0; i < birthdates.Length; i++)
            {
                Console.WriteLine(birthdates[i]);
            }

            //Loop where comparison thats used to determine to continue iterating loop is <=
            for (int i = 1; i <= birthdates.Length; i++)
            {
                Console.WriteLine(birthdates[i - 1]);
            }

            //Part-4 assignment 
            //List of strings
            List<string> names = new List<string>() { "Garrett", "Gary", "Sandra", "Delaney", "Shannon" };

            //User input to search for item in list
            Console.WriteLine("Please enter text to search for unique items");
            string searchItems = Console.ReadLine();
            foreach (string name in names)
            {
                if (searchItems.Contains(name))
                {
                    Console.WriteLine("You have located the unique item: " + name);
                }
                else
                {
                    Console.WriteLine("You have inputed invalid characters");
                }
            }

            //Part-5 of assignment
            //List of strings w/ 2 identical items in it
            List<string> motorcycles = new List<string>() { "Harley", "Indian", "Victory", "BMW", "Harley", "Honda" };

            //User input to search for item in list
            Console.WriteLine("Please enter text to search for item in list");
            string searchCycle = Console.ReadLine();

            //Loop that iterates through list and displays index of list item w/ matching text even if only a single character
            bool foundAny = false;
            if (!string.IsNullOrEmpty(searchCycle))
            {
                for (int idx = 0; idx < motorcycles.Count; idx++)
                {
                    string cycle = motorcycles[idx];
                    if (cycle.Contains(searchCycle))
                    {
                        Console.WriteLine("A match or matches have been found based on your search: " + cycle);
                        foundAny = true;
                    }
                }
            }

            if (!foundAny)
            {
                Console.WriteLine("No matches have been found");
            }

            //Part-6 of assignment
            //List of strings having 2 identical strings in list
            List<string> guitars = new List<string>() { "Fender", "Gibson", "Harmony", "Gretsch", "Ibanez", "LTD", "Gretsch" };

            Console.WriteLine("Program will now search list for duplicate indices");
            Console.ReadLine();

            //Foreach loop evaluaating each item, and message stating if item has alreay appeared
            var dup = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            int index = 0;  


            foreach (string guitar in guitars)
            {
                bool added = dup.Add(guitar); //Returns false when string exists
                Console.WriteLine($"[{index}] {guitar} {(added ? "(unique)" : "(is a duplicate)")}");
                index++;
            }
        }
    }
}
