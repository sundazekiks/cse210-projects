using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        int magicNumber = int.Parse(Console.ReadLine());
        
        bool keep_asking = true;

        while (keep_asking)
        {
            Console.Write("What is your guess? ");
            int guessNumber = int.Parse(Console.ReadLine());

            if (guessNumber == magicNumber)
            {
                Console.Write("You guessed it!");
                break;
            }
            else if (guessNumber > magicNumber)
            {
                Console.WriteLine("Lower");

            }
            else
            {
                Console.WriteLine("Higher");
            }
        }
    }
}