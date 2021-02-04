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

            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
        }
    }
}
