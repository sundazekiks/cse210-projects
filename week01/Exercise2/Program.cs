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

        // Get the last digit of the grade
        char last_d_str = grade_str[grade_str.Length - 1];
        // Need to convert the last d str to an integer
        int last_digit = int.Parse(last_d_str.ToString());
        // A variable for storing + and - sign
        string symbols;

        if (last_digit < 3)
        {
            symbols = "-";
        }
        else if (last_digit >= 7)
        {
            symbols = "+";
        }
        else
        {
            symbols = "";
        }




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

        // Extra improvement on the code regarding A+, F+ and F-
        if (grade > 90 && last_digit >= 7)
        {
            symbols = "";
            Console.WriteLine($"You got a {letter}{symbols}");
        }
        else if (letter == "F")
        {
            symbols = "";
            Console.WriteLine($"You got a {letter}");
        }
        else
        {
            Console.WriteLine($"You got a {letter}{symbols}");
        }

        // Printing out the messages that corresponds to each grade
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