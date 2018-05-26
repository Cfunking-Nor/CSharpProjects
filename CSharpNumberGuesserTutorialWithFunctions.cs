using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {

            getAppInfo(); //Run getAppInfo Function to get the Information
            GreetUser(); //Ask for the user's Information and Greet
            while (true)
            {
                //Generate a random Number
                Random random = new Random();
                int correctNumber = random.Next(1, 10);
                //Guess Variable
                int guess = 0;
                //Ask user for a number
                Console.WriteLine("Guess a number between 1 and 10");
                //While loop to continue the ALGORITHM of guessing
                while (guess != correctNumber)
                {
                    //Get User Input
                    string input = Console.ReadLine();
                    //Make sure it's a number
                    if (!int.TryParse(input, out guess))
                    {
                        //Print error message
                        PrintColorMessage(ConsoleColor.Red,"That's not a number");
                        continue;
                    }
                    //Cast to Int and put in guess
                    guess = Int32.Parse(input);
                    //Match guess to correct number ALGORITHM
                    if (guess != correctNumber)
                    {
                        PrintColorMessage(ConsoleColor.Red, "Wrong Number Please Try Again");
                        continue;
                    }
                }
                //Output Success Message
                PrintColorMessage(ConsoleColor.Yellow, "You Guessed It");
                //Ask to Play Again
                Console.WriteLine("Play Again [Y or N]");
                string answer = Console.ReadLine().ToUpper();
                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }

            }
        }

        static void getAppInfo()
        {
            //App Information
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Brad Traversy";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
            Console.ResetColor();
        }
        static void GreetUser()
        {
            //Ask the User what his Name
            Console.WriteLine("What is your Name?");
            string inputName;
            inputName = Console.ReadLine();
            Console.WriteLine("Hello {0} Let's Play a Game...", inputName);
        }

        //Print color message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }


    }
}
