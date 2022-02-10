// See https://aka.ms/new-console-template for more information
using System;

namespace Wordle // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your green letters (Use underscores for blanks)");
            var green = Console.ReadLine();
            Console.WriteLine("Enter your yellow letters (Use underscores for blanks)");
            var yellow = Console.ReadLine();
            Console.WriteLine("Enter your grey letters");
            var grey = Console.ReadLine();

            Wordle.Guess(green, yellow, grey);
        }
    }
}