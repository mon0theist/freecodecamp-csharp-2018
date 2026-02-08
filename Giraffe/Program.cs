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
            
            // DATA TYPES
            string phrase = "Giraffe Academy";
            char grade = "A"; // can only contain a single char
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



            Console.ReadLine(); // keeps the console open instead of immediately terminating
        }
    }
}
