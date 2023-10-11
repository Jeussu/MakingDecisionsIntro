# MakingDecisionsIntro
53. Making Decisions Intro

Ra quyết định Giới thiệu

Trong C#, bạn có thể đưa ra quyết định trong chương trình của mình bằng cách sử dụng các câu điều kiện. Các câu lệnh có điều kiện cho phép bạn thực thi các khối mã khác nhau dựa trên các điều kiện nhất định. Hai câu điều kiện chính trong C# là:

1. câu lệnh if:
    Câu lệnh `if` được sử dụng để kiểm tra một điều kiện và nếu điều kiện đó đúng, thì khối mã bên trong câu lệnh `if` sẽ được thực thi. Nếu điều kiện là sai, khối mã sẽ bị bỏ qua.

    using System;

Syntax:
   ```csharp
   if (condition)
   {
    // Code to execute if the condition is true
}
   ```
    Ví dụ:
    ```csharp
   int number = 10;
if (number > 5)
{
    Console.WriteLine("The number is greater than 5.");
}
   ```
2. Câu lệnh if-else:
    Câu lệnh `if-else` được sử dụng khi bạn muốn thực thi một khối mã nếu điều kiện là đúng và một khối mã khác nếu điều kiện là sai.

    Cú pháp:
    ```csharp
   if (condition)
   {
    // Code to execute if the condition is true
}
   else
{
    // Code to execute if the condition is false
}
    Ví dụ:
    ```csharp
   int age = 20;
if (age >= 18)
{
    Console.WriteLine("You are an adult.");
}
else
{
    Console.WriteLine("You are a minor.");
}
   ```
3. Câu lệnh if-else if-else:
    Câu lệnh `if-else if-else` được sử dụng khi bạn có nhiều điều kiện cần kiểm tra. Nó cho phép bạn xâu chuỗi nhiều điều kiện và thực thi khối mã tương ứng với điều kiện thực đầu tiên. Nếu không có điều kiện nào đúng, thì khối mã bên trong câu lệnh `else` (nếu được cung cấp) sẽ được thực thi.

    Cú pháp:
    ```csharp
   if (condition1)
   {
    // Code to execute if condition1 is true
}
   else if (condition2)
{
    // Code to execute if condition1 is false and condition2 is true
}
else
{
    // Code to execute if both condition1 and condition2 are false
}
   ```
    Ví dụ:
```csharp
   int score = 85;
if (score >= 90)
{
    Console.WriteLine("Excellent!");
}
else if (score >= 80)
{
    Console.WriteLine("Good!");
}
else if (score >= 70)
{
    Console.WriteLine("Average.");
}
else
{
    Console.WriteLine("Need improvement.");
}
   ```
Các câu lệnh điều kiện này cho phép bạn kiểm soát luồng chương trình của mình dựa trên các điều kiện khác nhau, giúp bạn có thể đưa ra quyết định và thực thi các khối mã cụ thể tương ứng.

My Code:
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's the temperature like?: ");
            string temperature = Console.ReadLine();
            int numTemp = int.Parse(temperature);

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

55. Intro to TryParse

`TryParse` là một phương pháp hữu ích trong C# cho phép bạn phân tích một đại diện chuỗi của một giá trị vào kiểu dữ liệu tương ứng của nó trong khi xử lý bất kỳ lỗi phân tích có thể một cách lịch sự. Phương pháp 'TryParse' có sẵn cho các loại dữ liệu khác nhau, chẳng hạn như 'int', 'double', 'float', 'decimal', 'bool', v.v.

Phương pháp `TryParse` cố gắng phân tích chuỗi đầu vào vào kiểu dữ liệu mong muốn. Nếu phân tích thành công, nó sẽ trả về 'true', và giá trị phân tích được lưu trữ trong tham số đầu ra được cung cấp. Nếu phân tích thất bại, nó sẽ trả về 'false', và tham số đầu ra sẽ không thay đổi.

Syntax for the `TryParse` method:

```csharp
public static bool TryParse(string s, out T result)
```
Ở đây, `T` là kiểu dữ liệu mục tiêu, và `s` là chuỗi bạn muốn phân tích. Từ khóa 'out' được dùng để chỉ ra rằng tham số'result' là một tham số đầu ra, có nghĩa là giá trị được phân tích sẽ được gán cho nó nếu phân tích thành công.

Ví dụ sử dụng `TryParse` với kiểu dữ liệu `int`:

```csharp
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
```
Trong ví dụ này, phương pháp 'int.TryParse' cố gắng phân tích 'numberString' thành 'int'. Nếu thành công, nó đặt biến `number` vào giá trị đã phân tích, và thông điệp "Parsing successful. Số là: 123" sẽ được hiển thị. Nếu quá trình phân tích thất bại, thông báo "Sự phân tích không thành công. Đầu vào không hợp lệ." sẽ được hiển thị.

Sử dụng `TryParse` là một cách an toàn hơn để phân tích các chuỗi bởi vì nó ngăn chặn các ngoại lệ bị ném trong trường hợp phân tích thất bại do nhập không hợp lệ, cho phép bạn xử lý các lỗi một cách lịch sự hơn trong mã của bạn.

56. IF And Else If + Try Parse

Sự kết hợp của `if`, `else if`, và `TryParse` trong C# cho phép bạn xử lý các trường hợp khác nhau dựa trên đầu vào do người dùng cung cấp. `TryParse` đặc biệt hữu ích khi bạn mong đợi người dùng nhập một giá trị có thể được chuyển đổi thành một loại dữ liệu cụ thể nhưng muốn xử lý các trường hợp mà đầu vào không hợp lệ.

Hãy minh hoạ điều này bằng một ví dụ nơi người dùng được yêu cầu nhập độ tuổi của họ, và chương trình sẽ phản hồi với một thông điệp khác nhau dựa trên tuổi tác của họ:

```csharp
using System;

class Program
{
    static void Main()
    {
        Console.Write("Please enter your age: ");
        string userInput = Console.ReadLine();

        if (int.TryParse(userInput, out int age))
        {
            // If TryParse is successful, the parsed value is stored in the 'age' variable.
            if (age < 0)
            {
                Console.WriteLine("Age cannot be negative.");
            }
            else if (age < 18)
            {
                Console.WriteLine("You are a minor.");
            }
            else if (age >= 18 && age < 65)
            {
                Console.WriteLine("You are an adult.");
            }
            else
            {
                Console.WriteLine("You are a senior citizen.");
            }
        }
        else
        {
            // If TryParse fails, the user entered an invalid input.
            Console.WriteLine("Invalid input. Please enter a valid age.");
        }
    }
}
```
Trong ví dụ này, chương trình đầu tiên yêu cầu người dùng nhập tuổi của họ. Đầu vào sau đó được đọc bằng cách sử dụng `Console.ReadLine()`, và `TryParse` được sử dụng để chuyển đổi chuỗi đầu vào thành số nguyên. Nếu phân tích thành công, giá trị được lưu trong biến `age`, và chương trình kiểm tra giá trị của `age' để xác định thông điệp thích hợp để hiển thị dựa trên độ tuổi của người dùng. Nếu việc phân tích thất bại (ví dụ, người dùng nhập một giá trị không phải số), chương trình sẽ hiển thị một thông báo lỗi cho biết rằng đầu vào không hợp lệ.

Sử dụng `TryParse` kết hợp với các cụm từ `if` và `else if` cho phép bạn xử lý các kịch bản khác nhau một cách lịch sự và cung cấp phản hồi có ý nghĩa cho người dùng, ngay cả trong trường hợp đầu vào không phải là những gì bạn mong đợi.

My Code:
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

57. Nested If Statements

Trong C#, câu lệnh if lồng nhau là một câu lệnh if được đặt bên trong một câu lệnh if khác. Nó cho phép bạn tạo các điều kiện phức tạp hơn bằng cách kiểm tra nhiều điều kiện trong cùng một khối mã logic. Câu lệnh if bên trong chỉ được thực thi nếu điều kiện của câu lệnh if bên ngoài là đúng. Đây là cú pháp cho các câu lệnh if lồng nhau:

```csharp
if (condition1)
{
    // Code to be executed if condition1 is true

    if (condition2)
    {
        // Code to be executed if both condition1 and condition2 are true
    }
    else
    {
        // Code to be executed if condition1 is true, but condition2 is false
    }
}
else
{
    // Code to be executed if condition1 is false
}
```
Đây là một ví dụ về việc sử dụng các câu lệnh if lồng nhau để xác định điều kiện thời tiết:

```csharp
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("What's the weather like today? (Enter Sunny, Cloudy, or Rainy):");
        string weather = Console.ReadLine();

        if (weather.Equals("Sunny", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("It's a sunny day!");

            Console.WriteLine("Is it hot? (Enter Yes or No):");
            string hot = Console.ReadLine();

            if (hot.Equals("Yes", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Don't forget to wear sunscreen!");
            }
            else
            {
                Console.WriteLine("Enjoy the pleasant weather!");
            }
        }
        else if (weather.Equals("Cloudy", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("It's a cloudy day. Bring an umbrella just in case!");
        }
        else if (weather.Equals("Rainy", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("It's raining. Don't forget your umbrella and raincoat!");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter Sunny, Cloudy, or Rainy.");
        }
    }
}
```
Trong ví dụ này, chúng tôi sử dụng các câu lệnh if lồng nhau để trước tiên kiểm tra các điều kiện thời tiết chung (Nắng, Nhiều mây hoặc Mưa). Nếu thời tiết nắng, thì chúng tôi sẽ hỏi người dùng xem trời có nóng không và đưa ra lời khuyên phù hợp dựa trên phản ứng của họ. Nếu thời tiết nhiều mây hoặc mưa, chúng tôi sẽ hướng dẫn cụ thể cho những điều kiện đó. Nếu người dùng nhập dữ liệu không hợp lệ, chúng tôi sẽ hiển thị thông báo lỗi.

Các câu lệnh if lồng nhau hữu ích khi bạn cần xem xét nhiều điều kiện và thực thi các khối mã khác nhau dựa trên các điều kiện đó. Tuy nhiên, việc sử dụng quá nhiều câu lệnh if lồng nhau có thể làm cho mã khó đọc và khó bảo trì hơn, vì vậy điều cần thiết là sử dụng chúng một cách thận trọng và xem xét các cấu trúc điều khiển khác như câu lệnh switch trong một số trường hợp nhất định.

My Code: 
using System;

namespace NestedIfStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isAdmin = false;
            bool isRegistered = true;
            string userName = "";
            Console.WriteLine("Please enter your username");


            userName = Console.ReadLine();
            if (isRegistered && userName != "" && userName.Equals("admin"))
            {
                Console.WriteLine("Hi There, registered user");

                Console.WriteLine("Hi there, " + userName);

                Console.WriteLine("Hi there, Admin");
            }

            if (isAdmin || isRegistered)
            {
                Console.WriteLine("You are logged in");
            }

            Console.Read();
        }
    }
}

Coding Exercise 3: Nested If Statements

This time you have to complete the NestedCheck method.

It is supposed to print the right message in the terminal depending on the given value:

            - when the value is divisible by 3. You have to print "Divisible by 3.";

            - when it is not divisible by 3, but divisible by 7 print "Divisible by 7."

            - Otherwise:

                                    - when it is an odd number, print "Odd number."

                                    - if not, print "Even number."

Example:

the number is equal to 3, "Divisible by 3." is printed;

the number is equal to 28, "Divisible by 7." is printed;

the number is equal to 1, "Odd number." is printed;

Solution in my code: 
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

58. Challenge - If Statements

Challenge - If Statements
Create a user Login System, where the user can first register and then Login in. The Program should check if the user has entered the correct username and password, wenn login in (so the same ones that he used when registering).
As we haven't covered storing data yet, just create the program in a way, that registering and logging in, happen in the same execution of it.
User If statements and User Input and Methods to solve the challenge.

Solution in my code:

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

59. Solution For The Challenge "If Statements"

namespace RegisteringAndLogginIn
{
    internal class Program
    {
        static string username;
        static string password;
        static void Main(string[] args)
        {
            Register();
            Login();
            Console.Read();
        }

        public static void Register()
        {
            Console.WriteLine("Please enter your username: ");
            username = Console.ReadLine();
            Console.WriteLine("Please enter your password:");
            password = Console.ReadLine();
            Console.WriteLine("Registration completed");
            Console.WriteLine("------------------------");
        }

        public static void Login()
        {
            Console.WriteLine("Please enter your username");
            if (username == Console.ReadLine())
            {
                Console.WriteLine("Please enter your password");
                if (password == Console.ReadLine())
                {
                    Console.WriteLine("Login successfull");
                }
                else
                {
                    Console.WriteLine("Login failed, wrong password. Restart Program");
                }
            }
            else
            {
                Console.WriteLine("Login failed, wrong username. Restart Program");
            }
        }
    }
}

60. Switch Statement

60. Tuyên bố chuyển đổi

Câu lệnh switch trong C# là một câu lệnh điều khiển cho phép bạn chọn một trong nhiều khối mã sẽ được thực thi dựa trên giá trị của một biến hoặc một biểu thức. Nó cung cấp một cách khác để xử lý nhiều điều kiện có thể xảy ra so với việc sử dụng nhiều câu lệnh if-else. Cú pháp của câu lệnh switch như sau:

```csharp
switch (expression)
{
    case value1:
        // Code block to be executed if expression matches value1
        break;
    case value2:
        // Code block to be executed if expression matches value2
        break;
    // More cases can be added here
    default:
        // Code block to be executed if expression does not match any of the cases
        break;
    }
```
Đây là một ví dụ về cách sử dụng câu lệnh switch:

```csharp
using System;

namespace SwitchExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a day number (1-7):");
            int dayNumber = int.Parse(Console.ReadLine());

            string dayName;

            switch (dayNumber)
            {
                case 1:
                    dayName = "Sunday";
                    break;
                case 2:
                    dayName = "Monday";
                    break;
                case 3:
                    dayName = "Tuesday";
                    break;
                case 4:
                    dayName = "Wednesday";
                    break;
                case 5:
                    dayName = "Thursday";
                    break;
                case 6:
                    dayName = "Friday";
                    break;
                case 7:
                    dayName = "Saturday";
                    break;
                default:
                    dayName = "Invalid day number";
                    break;
            }

            Console.WriteLine("The day is: " + dayName);
        }
    }
}
```
Trong ví dụ này, người dùng được yêu cầu nhập số ngày từ 1 đến 7. Sau đó, câu lệnh switch sẽ kiểm tra giá trị của `dayNumber` và dựa trên giá trị đó, nó gán tên ngày tương ứng cho biến `dayName`. Nếu người dùng nhập một số nằm ngoài phạm vi từ 1-7, thì trường hợp `default` sẽ được thực thi và chương trình sẽ gán "Số ngày không hợp lệ" cho `dayName`.
My code: 
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

Challenge - If Statements 2
Create an application with a score, highscore and a highscorePlayer.
Create a method which has two parameters, one for the score and one for the playerName.
When ever that method is called, it should be checked if the score of the player is higher than the highscore, if so, "New highscore is + " score" and in another line "New highscore holder is " + playerName - should be written onto the console, if not "The old highscore of " + highscore + " could not be broken and is still held by " + highscorePlayer.
Consider which variables are required globally and which ones locally.

Solution in my code:
namespace ChallengeIfStatements2
{
    internal class Program
    {
        static int highscore = 300;
        static string highscorePlayer = "Vinh";
        static void Main(string[] args)
        {
            // Initialize the score and playerName locally for testing purpose

            CheckAndUpdateHighScore(250, "Thanh");
            CheckAndUpdateHighScore(315, "Hanh");
            CheckAndUpdateHighScore(350, "Tuan");
            
            Console.Read();
        }

        public static void CheckAndUpdateHighScore(int score, string playerName)
        {
            //check if the current score is higher than the existing hightscore
            if (score > highscore)
            {
                // If yes, update the hightscore and hightscorePlayer
                highscore = score;
                highscorePlayer = playerName;

                Console.WriteLine("New highscore is: " + score);
                Console.WriteLine("New highscore holder is: " + playerName);
            }
            else
                Console.WriteLine("The old hightscore could not be broken. It is still "
                    + highscore + " and held by " + highscorePlayer);
        }
    }
}

63. Enhanced If Statements - Ternary Operator
63. Câu lệnh If nâng cao - Toán tử ternary

Toán tử bậc ba là một cách ngắn gọn để viết câu lệnh if-else trong C#. Nó có cú pháp như sau:

```csharp
variable = (condition) ? expressionIfTrue : expressionIfFalse;
```
Đây là cách nó hoạt động:

1. Điều kiện được đánh giá. Nếu nó là true, thì `biểu thứcIfTrue` sẽ được gán cho biến.
2. Nếu điều kiện là sai, thì `biểu thứcNếu sai` sẽ được gán cho biến.

Toán tử bậc ba có thể hữu ích khi bạn muốn gán giá trị cho một biến dựa trên một điều kiện trong một dòng mã. Nó thường được sử dụng cho các trường hợp if-else đơn giản.

Ví dụ 1:

```csharp
int age = 25;
string message = (age >= 18) ? "You are an adult." : "You are a minor.";
Console.WriteLine(message); // Output: "You are an adult."
```
Ví dụ 2:

```csharp
int num = -5;
string result = (num >= 0) ? "Positive" : "Negative";
Console.WriteLine(result); // Output: "Negative"
```
Trong các ví dụ này, toán tử bậc ba kiểm tra điều kiện và gán thông báo thích hợp cho biến `message` và `result`, tương ứng. Nếu điều kiện là đúng, nó sẽ gán biểu thức đầu tiên (sau `?`) và nếu điều kiện sai, nó sẽ gán biểu thức thứ hai (sau `:`).

My code: 
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

64. Enhanced If Statements - Ternary Operator – Challenge
Enhanced If Statements - Ternary Operator - Challenge
We have studied ternary operators and their usage so here is a small challenge for you. Let's create a small application that takes a temperature value as input and checks if the input is an integer or not.

If the input value is not an integer value, it should print to the console "Not a valid Temperature".

And if the input value is the valid integer then it should work as mentioned below.

If input temperature value is <=15 it should write "it is too cold here" to the console.

If input temperature value is >= 16 and is <=28 it should write "it is ok" to the console.

If the input temperature value is > 28 it should write "it is hot here" to the console.

Make sure to use ternary operators and not if statements to check for the three conditions, however you can use if statement for the other conditions like to check if the entered value is a valid integer or not.

Solution in my code:

using System;

namespace TemperatureCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the temperature: ");
            string input = Console.ReadLine();

            // Check if the input is a valid integer
            bool isValidInput = int.TryParse(input, out int temperature);

            if (isValidInput)
            {
                // Check temperature range using ternary operators
                string result = (temperature <= 15) ? "it is too cold here"
                              : (temperature >= 16 && temperature <= 28) ? "it is ok"
                              : "it is hot here";

                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Not a valid Temperature");
            }
        }
    }
}
