using System;

namespace SwitchStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 25;
            switch (age)
            {
                case 15:
                    Console.WriteLine("Too young to party in the club!");
                    break;
                case 25:
                    Console.WriteLine("Good to go!");
                    break;
                default:
                    Console.WriteLine("How old are you then?");
                    break;
            }

            if (age == 15)
            {
                Console.WriteLine("Too young to party in the club!");
            }
            else if (age == 25)
            {
                Console.WriteLine("God to go!");
            }
            else
            {
                Console.WriteLine("How old are you then?");
            }

            string username = "Vinh";

            switch (username)
            {
                case "Vinh":
                    Console.WriteLine("username is vinh");
                    break;
                case "Thanh":
                    Console.WriteLine("username is thanh");
                    break;
                default:
                    Console.WriteLine("username is unknown");
                    break;
            }

            Console.Read();
        }
    }
}

