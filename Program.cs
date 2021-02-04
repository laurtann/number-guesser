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
            string userName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", userName);

            // init correct number
            int correctNumber = 7;

            // init guess var
            int guess = 0;

            // ask user for number
            Console.WriteLine("Guess a number between 1 and 10");

            while(guess != correctNumber)
            {
                // get user input
                string userInput = Console.ReadLine();

                // cast to int and put into guess var
                guess = Int32.Parse(userInput);

                // match guess to correct num
                if (guess != correctNumber)
                {
                    // change text clr
                    Console.ForegroundColor = ConsoleColor.Green;

                    // tell user wrong guess
                    Console.WriteLine("Wrong number, please try again");

                    // reset clr - makes the rest of the text white again
                    Console.ResetColor();
                }
            }

            // output success msg
            // change text clr
            Console.ForegroundColor = ConsoleColor.Yellow;

            // tell user wrong guess
            Console.WriteLine("Correct!");

            // reset clr - makes the rest of the text white again
            Console.ResetColor();

        }
    }
}

