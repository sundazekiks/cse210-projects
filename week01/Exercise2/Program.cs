using System;

class Program
{
    static void Main(string[] args)
    {

        // Prompt user for grade percentage:
        Console.Write("Enter your grade: ");
        string grade_str = Console.ReadLine();
        //convert grade str to an integer
        int grade = int.Parse(grade_str);
        // creating a letter variable to store in the letter grade
        string letter;

        // If statements for determining what letter grade did the user get
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"You got a {letter}");

        if (grade > 70)
        {
            Console.WriteLine("Congratulations, You passed the class!");
        }
        else
        {
            Console.WriteLine("Oh you failed, but don't worry there's always next time!");
        }



    }
}