using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment JakeAssignment = new MathAssignment("Roberto Rodriguez", "Section 7.3", "8-19", "Fractions");

       Console.WriteLine(JakeAssignment.getSummary());
       Console.WriteLine(JakeAssignment.GetHomeworkList());
        Console.WriteLine("");

        WritingAssignment JohnAssigment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(JohnAssigment.getSummary());
        Console.WriteLine(JohnAssigment.GetWritingInformation());

    }
}