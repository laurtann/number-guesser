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
            GetAppInfo(); // run func for app info

            GreetUser(); // Ask user name & greet

            while (true) {

                // init correct number
                // int correctNumber = 7;

                // create random object
                Random random = new Random();

                int correctNumber = random.Next(1, 11);

                // init guess var
                int guess = 0;

                // ask user for number
                Console.WriteLine("Guess a number between 1 and 10");

                while(guess != correctNumber)
                {
                    // get user input
                    string userInput = Console.ReadLine();

                    // make sure input is number
                    if (!int.TryParse(userInput, out guess))
                    {
                        // print error msg
                        PrintColorMessage(ConsoleColor.Red, "Please enter a number");

                        //keep going
                        continue;
                    }

                    // cast to int and put into guess var
                    guess = Int32.Parse(userInput);

                    // match guess to correct num
                    if (guess != correctNumber)
                    {
                        // print error msg
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");
                    }
                }

                // output success msg
                PrintColorMessage(ConsoleColor.Green, "Correct!");

                // ask to play again
                Console.WriteLine("Play again? (Y or N)");

                // get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y") {
                    continue;

                } else if (answer == "N") {
                    return;
                }
            }

        }

        // get and display app info
        static void GetAppInfo() {
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
        }

        // get user name and make greeting
        static void GreetUser() {
            // ask user for name
            Console.WriteLine("What is your name?");

            // get user input
            string userName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", userName);
        }

        static void PrintColorMessage(ConsoleColor color, string message) {
            // change text clr
            Console.ForegroundColor = color;

            // tell user wrong input type
            Console.WriteLine(message);

            // reset clr - makes the rest of the text white again
            Console.ResetColor();
        }
    }
}

