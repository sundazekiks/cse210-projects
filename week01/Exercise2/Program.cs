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

        // Determine which letter grade the user got
        if (grade >= 90)
        {
            Console.WriteLine("A");
        }
        else if (grade >= 80)
        {
            Console.WriteLine("B");
        }
        else if (grade >= 70)
        {
            Console.WriteLine("C");
        }
        else if (grade >= 60)
        {
            Console.WriteLine("D");
        }
        else
        {
            Console.WriteLine("F");
        }

        // Separate Statement for printing out a message for the user if they pass or not
        if (grade > 70)
        {
            Console.WriteLine("Congratulations you passed the class!");
        }
        else {
            Console.WriteLine("Oh, you failed the class, but there's always next time! focus on the next one! Good Luck!");
        }




    }
}