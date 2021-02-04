using System;

namespace NumberGuesser
    
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAppInfo(); // Run func to print app info

            GreetUser(); // Ask user for name & greet

            while (true) {

                // Create random object
                Random random = new Random();

                // Random number btw 1 and 10
                int correctNumber = random.Next(1, 11);

                // Set initial guess to 0
                int guess = 0;

                // Prompt user for guess
                Console.WriteLine("Guess a number between 1 and 10");

                while(guess != correctNumber)
                {
                    // Get user input
                    string userInput = Console.ReadLine();

                    // Check that user input is an int
                    if (!int.TryParse(userInput, out guess))
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Please enter a number");

                        continue;
                    }

                    // Cast user input to int and put into guess var
                    guess = Int32.Parse(userInput);

                    // Match guess to correct num
                    if (guess != correctNumber)
                    {
                        // Print error msg
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");
                    }
                }

                // Output success msg
                PrintColorMessage(ConsoleColor.Green, "Correct!");

                // Ask user to play again
                Console.WriteLine("Play again? (Y or N)");

                // Get user answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y") {
                    continue;

                } else if (answer == "N") {
                    return;
                }
            }

        }

        // Display app info
        static void GetAppInfo() {
            // set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "laurtann";

            // Change text clr
            Console.ForegroundColor = ConsoleColor.Green;

            // App info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            Console.ResetColor();
        }

        // Get user's name and make greeting
        static void GreetUser() {
            Console.WriteLine("What is your name?");

            // Get user input
            string userName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", userName);
        }

        static void PrintColorMessage(ConsoleColor color, string message) {
            // Change text clr
            Console.ForegroundColor = color;

            // Error or success msg
            Console.WriteLine(message);

            Console.ResetColor();
        }
    }
}

