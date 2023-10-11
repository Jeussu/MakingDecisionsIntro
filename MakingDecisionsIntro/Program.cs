using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's the temperature like?: ");
            string temperature = Console.ReadLine();
            int numTemp;
            int number;
            bool userEnteredNumber = int.TryParse(temperature, out number);
            if (userEnteredNumber)
            {
                numTemp = number;
            }
            else
            {
                numTemp = 0;
                Console.WriteLine("value entered, was no number. 0 set as temperature");
            }

            if (numTemp < 20)
            {
                Console.WriteLine("Take the coat");
            }
            else if (numTemp == 20)
            {
                Console.WriteLine("Pants and Pull Over should be fine");
            }
            else if (numTemp > 30)
            {
                Console.WriteLine("It's super hot!");
            }
            else
            {
                Console.WriteLine("Shorts are enough today");
            }

            Console.Read();
        }
    }
}