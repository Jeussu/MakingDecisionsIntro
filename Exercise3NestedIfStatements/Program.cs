using System;

namespace NestedCheckMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;

            // Read the input number from the user
            Console.WriteLine("Enter a number:");
            string input = Console.ReadLine();

            // Try parsing the input to an integer
            if (int.TryParse(input, out number))
            {
                // Call the NestedCheck method with the entered number
                NestedCheck(number);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }

            Console.Read();
        }

        public static void NestedCheck(int number)
        {
            // Check if the number is divisible by 3
            if (number % 3 == 0)
            {
                Console.WriteLine("Divisible by 3.");
            }
            // Check if the number is divisible by 7
            else if (number % 7 == 0)
            {
                Console.WriteLine("Divisible by 7.");
            }
            else
            {
                // Check if the number is odd
                if (number % 2 != 0)
                {
                    Console.WriteLine("Odd number.");
                }
                else
                {
                    Console.WriteLine("Even number.");
                }
            }
        }
    }
}
