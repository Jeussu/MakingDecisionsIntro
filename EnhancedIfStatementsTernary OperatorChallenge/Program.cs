namespace EnhancedIfStatementsTernary_OperatorChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputTemperature = 0;
            string temperatureMessage = string.Empty;
            string inputValue = string.Empty;

            // takes input from console
            Console.WriteLine("Enter the current temperature: ");
            inputValue = Console.ReadLine();

            // validate the input as valid input integer value
            bool validInteger = int.TryParse(inputValue, out inputTemperature);

            if (validInteger)
            {    //condition ? iftrue : iffalse
                // if is valid integer then it will check for the conditions using nested ternary operator here.
                temperatureMessage = inputTemperature <= 15 ?
                    //true 
                    "it is too cold here" :
                    //false
                    (inputTemperature >= 16 && inputTemperature <= 28) ?
                    // true
                    "it is cold here" :
                    // false
                    inputTemperature > 28 ?
                    // true
                    "it is hot here" :
                    //false
                    "";
                Console.WriteLine(temperatureMessage);
            }
            else
            {
                // in case if the input value is not a valid temperature
                Console.WriteLine("Not a valid temperature");
            }
            Console.ReadKey();
        }
    }
}