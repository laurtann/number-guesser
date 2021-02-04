using System;

// Namespace
namespace NumberGuesser
    
{
    // Main Class
    class Program
    {
        // Entry Point Method - void means that it isn't going to return a val
        // Static - no instances refers to func itself
        static void Main(string[] args)
        {
            // set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "laurtann";

            // change text clr
            Console.ForegroundColor = ConsoleColor.Green;

            // app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // reset clr - makes the rest of the text white again
            Console.ResetColor();

            // ask user for name
            Console.WriteLine("What is your name?");
            
            // get user input
            string input = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", input);

            // init correct number
            int correctNumber = 7;

            // init guess var
            int guess = 0;

            // ask user for number
            Console.WriteLine("Guess a number between 1 and 10");

            while(guess != correctNumber)
            {
                Console.WriteLine("Guess a number between 1 and 10");
            }

        }
    }
}

