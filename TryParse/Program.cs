string numberString = "123";
int number;

if (int.TryParse(numberString, out number))
{
    Console.WriteLine("Parsing successful. The number is: " + number);
}
else
{
    Console.WriteLine("Parsing failed. Invalid input.");
}
