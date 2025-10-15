using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");
        
        List<Activity> activities = new List<Activity>();

        Running run1 = new Running(3.0, 30.0);
        Bicycle bike1 = new Bicycle(15.0, 30.0, 7.5);
        Swimming swim1 = new Swimming(60, 30.0);

        activities.Add(run1);
        activities.Add(bike1);
        activities.Add(swim1);


        DisplaySummaryList(activities);




    }

    public static void DisplaySummaryList(List<Activity> activities)
    {
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }

}