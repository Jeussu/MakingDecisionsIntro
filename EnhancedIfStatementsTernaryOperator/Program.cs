    using System;

    namespace EnhancedIfStatementsTernaryOperator
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                // condition ? First_expression : second_expression; 
                // condition has to be either true or false
                // The conditional operator is right = associative.
                // The expression a ? b: c? d: e
                // is evaluated as a ? b : (c ? d : e),
                // not as (a? b : c) ? d : e.
                // The conditional operator cannot be overloaded

                // in celcius
                int temperature = -5;
                string stateOfMatter;

                if (temperature < 0)
                    stateOfMatter = "solid";
                else if (temperature > 100)
                    stateOfMatter = "gas";
                else
                    stateOfMatter = "liquid";

                Console.WriteLine("State of matter is {0}", stateOfMatter);

                temperature += 30;

                // in short:
                // if else advanced
                stateOfMatter = temperature < 0 ? "solid" : "liquid";

                // challenge - add the gas state of matter to the options
                temperature += 100;
                stateOfMatter = temperature > 100 ? "gas" : temperature < 0 ? "solid" : "liquid";

                Console.WriteLine("State of matter is {0}", stateOfMatter);
                Console.ReadKey();

            }
        }
    }

