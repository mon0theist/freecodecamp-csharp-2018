// NEW WAY
// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// OLD WAY
using System;

namespace Giraffe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // HELLO WORLD
            Console.WriteLine("Hello, World!");

            // VARIABLES AND STRINGS
            string characterName = "John";
            int characterAge = 35;
            Console.WriteLine($"There once was a man named {characterName}");
            Console.WriteLine($"He was {characterAge} years old");
            // change variable value
            characterName = "Lil' Stevie";
            Console.WriteLine($"He really liked the name {characterName}");
            Console.WriteLine($"But didn't like being {characterAge}");
            
            // BASIC DATA TYPES
            string phrase = "Giraffe Academy"; // DOUBLE QUOTES
            char grade = 'A'; // SINGLE QUOTES, can only contain a single char
            // char badgrade = "FFF"; // what happens if I do more than a single char? Maybe it will fail to compile and run?
            // yep: "The build failed. Fix the build errors and run again."
            int count = 1;
            int negative = -1;
            // less precise >>> more precise
            // float, double, decimal
            // C# defaults to Doubles unless you specify something else
            float pi = 3.1415927f; // even though you declared float, C# defaults to Double, so lowercase f is also needed
            double piDouble = 3.141592653589793; // C# defaults to Double, so no suffix needed
            decimal piDecimal = 3.1415926535897932384626433833m; // used when precision is absolutely crucical, like financial data. think "m" = "money"
            bool isMale = true;
            bool isFemale = false;

            // STRINGS
            Console.WriteLine("This is a string of text");
            Console.WriteLine("The second half of this text string\n is on a second line.");
            Console.WriteLine("This qutation mark is escaped (\")");
            string phrase2 = "Giraffe Academy";
            Console.WriteLine(phrase2);
            Console.WriteLine(phrase2.Length);
            Console.WriteLine(phrase2.ToUpper());
            Console.WriteLine(phrase2.ToLower());
            Console.WriteLine(phrase2.Contains("Academy")); // returns bool
            Console.WriteLine(phrase2.IndexOf("Academy")); // first result/match, -1 means not in string 
            Console.WriteLine(phrase2.Substring(8,3)); // starting index, chars to grab
            string concat = "I prefer formatted strings " + "instead of concatenation.";

            // NUMBERS
            Console.WriteLine(100);
            Console.WriteLine(-100);
            Console.WriteLine(100.001);
            Console.WriteLine(1 + 1);
            Console.WriteLine(1 - 1);
            Console.WriteLine(1 * 1);
            Console.WriteLine(1 / 1);
            Console.WriteLine(1 % 1);
            Console.WriteLine(1 + 1 * 3); // PEMDAS
            Console.WriteLine( 5.1 + 8.1 ); // decimal answer
            int num = 1;
            num++;
            Console.WriteLine(Math.Abs(-100)); // absolute value
            Console.WriteLine(Math.Pow(2,3)); // exponents
            Console.WriteLine(Math.Sqrt(144)); // sq. rt.
            Console.WriteLine(Math.Max(4, 90));
            Console.WriteLine(Math.Min(4, 90));
            Console.WriteLine(Math.Round(4.325)); // standard rounding rules 

            // USER INPUT
            Console.Write("Enter your name: "); // as opposed to WriteLine (no newline)
            string name = Console.ReadLine(); // waiting for user input
            Console.Write("Enter your age: "); // no newline
            string age = Console.ReadLine();
            Console.WriteLine($"Hello {name} who is age {age}"); // format string
            
            // CALCULATOR
            int numb = Convert.ToInt32("45"); // Convert string to int
            Console.WriteLine(numb + 6);

            Console.Write("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num1 + num2);
            // must use same data type. ints cant be added to floats, must convert both to doubles
            // Convert.ToDouble(Console.ReadLine());

            // MADLIBS
            Console.Write("Enter a color: ");
            string color = Console.ReadLine();
            Console.Write("Enter a plural noun: ");
            string pluralNoun = Console.ReadLine();
            Console.Write("Enter a celebrity: ");
            string celebrity = Console.ReadLine();

            Console.WriteLine($"Roses are {color}");
            Console.WriteLine($"{pluralNoun} are blue");
            Console.WriteLine($"I Love {celebrity}");

            // ARRAYS
            int[] numbers = {4, 8, 15, 16, 23, 42};
            Console.WriteLine(numbers[1]);
            numbers[1] = 900; // change value in array
            string[] friends = new string[10]; // empty array, specify number of elements to hold
            friends[0] = "Jim";
            friends[1] = "Pam";
            friends[2] = "Dwight";

            // METHODS (see line 123)
            SayHi("Cornelius", 99); // see SayHi method defined below. basically the same as custom functions?
            
            // RETURN STATEMENT (see line 133)
            cubeNum(3);
            int cubedNumber = cubeNum(5);

            // IF STATEMENTS
            // Logical AND: &&
            // Logical OR: ||
            bool isDude = false;
            bool isTall = true;
            if (isDude && isTall) {
                Console.WriteLine("You are a tall male.");
            }
            else if (!isDude && !isTall) {
                Console.WriteLine("You a short-ass lil bitch.");
            }
            else {
                Console.WriteLine("Womp womp");
            }

            // IF STATEMENTS (CONTD.)
            // See Max method below
            // C# has standard comparators 
            Console.WriteLine(GetMax(2, 10));

            // BETTER CALCULATOR
            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Operator: ");
            string op = Console.ReadLine();

            Console.Write("Enter a number: ")
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (op == "+") {

            }
            else if (op == "-") {

            }
            else if (op == "x" || op == "*") {

            }
            else if (op == "/"){

            }
            else if (op == "%"){

            }
            else {
                Console.WriteLine("ERROR: Invalid Operator");
            }


            // SWITCH STATEMENTS 
            DayNum(2); // Tuesday

            Console.ReadLine(); // keeps the console open instead of immediately terminating
        }
        // Creating Method, between "internal class Program" and "static void Main"
        // will learn "static" and the rest of this structure later
        // [static] [return type] [Method Name]
        static void SayHi(string name, int age) 
        {
            Console.WriteLine($"Hello {name}, age: {age} (SayHi method)");
        }

        // Creating Method for RETURN STATEMENTS section
        // [static] [return type] [Method Name]
        static int cubeNum(int number) {
            int result = (number * number * number);
            return result;
        }

        static int GetMax(int num1, int num2) {
            int result;
            if (num1 > num2) {
                result = num1;
                return result;
            }
            else if (num2 > num1){
                result = num2;
                return result;
            }
            else {
                Console.WriteLine("Numbers are equal");
                return num1;
            }
        }
        // SWITCH STATEMENTS
        static string GetDay(int dayNum) {
            string dayName;
            
            switch (dayNum) {
                case 0:
                    dayName = "Sunday";
                    break;
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
            }

            return dayName;
        }

    }
}
