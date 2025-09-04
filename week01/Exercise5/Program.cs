using System;

class Program
{
    static void Main(string[] args)
    {

        DisplayWelcome();

        string userName = PromptUserName();
        int favNum = PromptUserNumber();

        int squareNum = SquareNumber(favNum);


        DisplayResult(userName, squareNum);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program");
    }
    static string PromptUserName()
    {
        // Prompt user for their name
        Console.Write("Enter your name: ");
        string username = Console.ReadLine();

        return username;
    }

    static int PromptUserNumber()
    {
        // Prompt user for their favorite number
        Console.Write("Enter your favorite number: ");
        int favNum = int.Parse(Console.ReadLine());

        return favNum;
    }

    // Getting the square
    static int SquareNumber(int number)
    {
        int square = number * number;

        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}