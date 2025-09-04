using System;

class Program
{
    static void Main(string[] args)
    {
        
        bool keep_asking = true;


        while (keep_asking)
        {

            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 100);

            //setting a count variable of how many times the user has guessed
            int count = 1;


            // I just wrote this line of code I used it for debugging :: Console.WriteLine(magicNumber);

            Console.Write("What is your guess? ");
            int guessNumber = int.Parse(Console.ReadLine());

            
            if (guessNumber == magicNumber)
            {
                Console.WriteLine($"You guessed it! after {count} times");

                // asking user if they wanna go again
                Console.Write("Wanna play again? ");
                string answer = Console.ReadLine();

                if (answer == "yes")
                {
                    keep_asking = true;
                }
                else
                {
                    keep_asking = false;
                    Console.WriteLine("Thank you for playing!");
                }
            }
            else if (guessNumber > magicNumber)
            {
                Console.WriteLine("Lower");
                count += 1;
            }
            else
            {
                Console.WriteLine("Higher");
                count += 1;
            }
        }

        
    }
}