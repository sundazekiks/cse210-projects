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
        else if (grade < 60)
        {
            Console.WriteLine("F");
        }




    }
}