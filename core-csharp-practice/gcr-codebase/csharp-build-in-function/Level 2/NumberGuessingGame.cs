using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.Build_In_Function
{
    class NumberGuessingGame
    {
        static void Main()
        {
            Console.WriteLine("number between 1 and 100");
            Console.WriteLine("I will try to guess it");
            Console.WriteLine("Respond with: high, low, or correct\n");

            PlayGame();
        }

        //game flow
        static void PlayGame()
        {
            int low = 1, high = 100;
            bool isguessed = false;

            while (!isguessed)
            {
                int guess = GenerateGuess(low, high);
                string feedback = GetUserFeedback(guess);
                isguessed = UpdateRange(feedback, guess, ref low, ref high);
            }
        }
        static int GenerateGuess(int low, int high)//random guess within range
        {
            Random rand = new Random();
            return rand.Next(low, high + 1);
        }
        static string GetUserFeedback(int guess)//feedback from the user
        {
            Console.Write($"Is {guess} high, low, or correct? ");
            return Console.ReadLine().ToLower();
        }      
        static bool UpdateRange(string feedback, int guess, ref int low, ref int high)
        {
            if (feedback == "correct")
            {
                Console.WriteLine("🎉 I guessed your number!");
                return true;
            }
            else if (feedback == "high")
            {
                high = guess - 1;
            }
            else if (feedback == "low")
            {
                low = guess + 1;
            }
            else
            {
                Console.WriteLine("Invalid input. Please type high, low, or correct.");
            }

            return false;
        }
    }
}
