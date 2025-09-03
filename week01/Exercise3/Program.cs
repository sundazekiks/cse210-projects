using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        int magicNumber = int.Parse(Console.ReadLine());
        Console.Write("What is your guess? ");
        int guessNumber = int.Parse(Console.ReadLine());

        if (guessNumber > magicNumber)
        {
            Console.WriteLine("Lower");
        }
        else if (guessNumber == magicNumber)
        {
            Console.WriteLine("You guessed it!");
        }
        else
        {
            Console.WriteLine("Higher");
        }
    }
}