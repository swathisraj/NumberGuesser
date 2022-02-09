using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAppInfo();

            GetGreet();

            //set correct number
            //int correctNo = 7;

            while(true)
            { 
            //int guess var
            int guess = 0;

            Console.WriteLine("guess a number between 1 and 10");

            //create a new random object
            Random random = new Random();
            int correctNo = random.Next(1, 11);

            while (guess != correctNo)
            {
                string input1 = Console.ReadLine();

                //make sure its a number
                if (!int.TryParse(input1, out guess))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("PLEASE PUT AN ACTUAL NUMBER");
                    Console.ResetColor();

                    continue;
                }

                //make it int and put in guess
                guess = Int32.Parse(input1);

                //match guesss to correctNo
                if (guess != correctNo)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("WRONG NUMBER PLEASE TRY AGAIN");
                    Console.ResetColor();

                }
            }
            Console.WriteLine("SUCCESSFUL");
                
            //ask to play again
            Console.WriteLine("Enter Y or N to play again");
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
        static void GetAppInfo()
        {
            //set app variables
            string appName = "number guesser";
            string appVersion = "1.0.0";
            string appAuthor = "swathi";
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("{0}: version {1} by {2}", appName, appVersion, appAuthor);
            Console.ResetColor();
        }

        static void GetGreet()
        {
            Console.WriteLine("what is your name");
            string input = Console.ReadLine();

            Console.WriteLine("Hello {0} lets play a game", input);

        }
    }
}
