using System;

class FestivalLuckyDraw
{
    static void Main()
    {
        Console.WriteLine("Diwali Mela Lucky Draw!");
        Console.WriteLine("Draw a number and win gifts!");
        Console.WriteLine("Win if your number divides by both 3 and 5");
        Console.WriteLine();
        
        while (true)  // keep running for visitors
        {
            Console.Write("Enter your number (0 to quit): ");
            string input = Console.ReadLine();
            
            int num;
            
            // check if its a valid number
            if (!int.TryParse(input, out num))
            {
                Console.WriteLine("That's not a number! Try again.");
                continue;  // go back to start of loop
            }
            
            if (num == 0)
            {
                Console.WriteLine("Thanks for playing! Happy Diwali!");
                break;  // exit
            }
            
            // check if wins - divisible by 3 AND 5
            if (num % 3 == 0 && num % 5 == 0)
            {
                Console.WriteLine("YOU WON A GIFT!");
                Console.WriteLine(num + " divides by both 3 and 5!");
            }
            else
            {
                Console.WriteLine("No gift this time, try again!");
                
                // give some hints
                if (num % 3 == 0)
                {
                    Console.WriteLine("(divides by 3 but not 5)");
                }
                else if (num % 5 == 0)
                {
                    Console.WriteLine("(divides by 5 but not 3)");
                }
                else
                {
                    Console.WriteLine("(doesn't divide by 3 or 5)");
                }
            }
            
            Console.WriteLine();  // empty line
        }
        
        Console.ReadKey();
    }
}