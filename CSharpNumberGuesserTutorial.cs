using System;

namespace NumberGuesser
{
class Program
  {
 static void Main(string[] args)
    { 
    //Ask the User what his Name
    Console.WriteLine("What is your Name?");
    string inputName;
    inputName = Console.ReadLine();
    Console.WriteLine("Hello {0} Let's Play a Game...",inputName);
   
    while(true)
     {
     //Generate a random Number
      Random random = new Random();
      int correctNumber = random.Next(1,10);
     //Guess Variable
      int guess = 0;
      
     //Ask user for a number
      Console.WriteLine("Guess a number between 1 and 10");
      
                          //While loop to continue the ALGORITHM of guessing
                          while(guess != correctNumber)
                          {
                            //Get User Input
                            string input = Console.ReadLine(); 
                              //Make sure it's a number
                                if(!int.TryParse(input, out guess))
                                {
                                  Console.ForegroundColor = ConsoleColor.Red;
                                  Console.WriteLine("That is not a number");
                                  Console.ResetColor();
                                  continue;
                                }
                            //Cast to Int and put in guess
                            guess = Int32.Parse(input);
                            //Match guess to correct number ALGORITHM
                            if(guess != correctNumber)
                            {
                             Console.ForegroundColor = ConsoleColor.Red;
                             Console.WriteLine("That is not Correct");
                             Console.ResetColor();
                             continue;
                            }
                        }
      
                        //Output Success Message
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("You Guessed It");
                        Console.ResetColor();
      
                        //Ask to Play Again
                        Console.WriteLine("Play Again [Y or N]");
                        string answer = Console.ReadLine().ToUpper();
                        
                        if (answer == "Y")
                        {
                          continue; 
                        }
                        else if(answer == "N")
                        {
                          return; 
                        }
                        else
                        {
                          return; 
                        }
                         
      }
    }
  } 
}
