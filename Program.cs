// See https://aka.ms/new-console-template for more information
using System;

namespace Wordle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string green = string.Empty;
            string yellow = string.Empty;
            string grey = string.Empty;

            while (green.Length != 5)
            {
                Console.WriteLine("Enter your green letters (Use underscores for blanks)");
                green = Console.ReadLine() ?? string.Empty;
            }

            while (yellow.Length != 5)
            {
                Console.WriteLine("Enter your yellow letters (Use underscores for blanks)");
                yellow = Console.ReadLine() ?? string.Empty;
            }

            Console.WriteLine("Enter your grey letters");
            grey = Console.ReadLine() ?? String.Empty;

            var guesses = Wordle.Guess(green, yellow, grey);

            foreach (var guess in guesses)
            {
                Console.WriteLine(guess);
            }
        }
    }
}