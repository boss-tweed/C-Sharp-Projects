using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Be the highest bidder!");
            const int reservePrice = 500;
            int bid = Convert.ToInt32(Console.ReadLine());
            bool highestBid = bid >= reservePrice;

            do
            {
                if (bid < reservePrice)
                {
                    string message = $"${bid} is not high enough. Try again.";
                    Console.WriteLine(message);
                    bid = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    string message = $"${bid} is the highest bid!";
                    Console.WriteLine(message);
                    highestBid = true;
                }
            }
            while (!highestBid);

            Console.ReadLine();

            Console.WriteLine("Make a choice!");
            int choice = Convert.ToInt32(Console.ReadLine());
            bool rightChoice = choice == 3;

            while (!rightChoice)
            {
                if (choice == 1)
                {
                    Console.WriteLine("You chose 1. Try again.");
                    choice = Convert.ToInt32(Console.ReadLine());
                }
                else if (choice == 2)
                {
                    Console.WriteLine("You chose 2. Try again.");
                    choice = Convert.ToInt32(Console.ReadLine());
                }
                else if (choice == 3)
                {
                    Console.WriteLine("You chose 3. That's correct!");
                    rightChoice = true;
                }
                else if (choice == 4)
                {
                    Console.WriteLine("You chose 4. Try again");
                    choice = Convert.ToInt32(Console.ReadLine());
                }
                else if (choice == 5)
                {
                    Console.WriteLine("You chose 5. Try again.");
                    choice = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Invalid choice. Try again.");
                    choice = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.ReadLine();

        }
    }
}

