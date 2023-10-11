namespace ChallengeIfStatements
{
    internal class Program
    {
        static string registeredUserName;
        static string registeredPassword;

        static void Main(string[] args)
        {
            Console.WriteLine("Wellcome to the User Login system!");
            //Registration
            Register();
            //Login
            Login();

            Console.WriteLine("Thank you for using the User Login Systems!");
            Console.ReadKey();
        }

        static void Register()
        {
            Console.WriteLine("Register a new user");
            Console.Write("Enter the user name: ");
            registeredUserName = Console.ReadLine();
            Console.Write("Enter a password: ");
            registeredPassword = Console.ReadLine();
            Console.WriteLine("Registration successfull!\n");
        }

        static void Login()
        {
            Console.WriteLine("Login");
            Console.Write("Enter your username: ");
            string enteredUsername = Console.ReadLine();

            Console.Write("Enter your password: ");
            string enteredPassword = Console.ReadLine();

            if (enteredUsername == registeredUserName & enteredPassword == registeredPassword)
            {
                Console.WriteLine("Login successfull!");
            }
            else
            {
                Console.WriteLine("Login failed. Incorrect username or password.");
            }
        }
    }
}