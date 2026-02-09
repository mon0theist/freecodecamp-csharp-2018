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
            

            Console.ReadLine(); // keeps the console open instead of immediately terminating
        }
    }
}
