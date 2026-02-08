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
            string characterName = "John";
            int characterAge = 35;

            Console.WriteLine("Hello, World!");
            
            Console.WriteLine($"There once was a man named {characterName}");
            Console.WriteLine($"He was {characterAge} years old");
            // change variable value
            characterName = "Lil' Stevie";
            Console.WriteLine($"He really liked the name {characterName}");
            Console.WriteLine($"But didn't like being {characterAge}");
            
            Console.ReadLine(); // keeps the console open instead of immediately terminating
        }
    }
}
