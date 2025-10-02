using System;

public class Listing : Activity
{
    private string _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

    private string[] _prompts = { "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?" };

    private List<string> answers = new List<string>();


    public void StartProgram()
    {
        Console.Write($@"
        Welcome to the Listing Actitvity
        
        {_description}

        ");

        Console.Write("How long, in seconds, would you like for your session? ");
        int answer = int.Parse(Console.ReadLine());

        GeneratePrompts(answer);

        Console.WriteLine("Well done!!");
        base.shortLoader();

        Console.WriteLine($"You have completed another {answer} seconds of the Reflecting Acitvity");
        base.shortLoader();
        
    }

    public void GeneratePrompts(int seconds)
    {
        Random rand = new Random();
        int LengthOfPrompts = _prompts.Length;
        int randomNumber = rand.Next(LengthOfPrompts);

        Console.WriteLine("Get Ready....");
        base.shortLoader();


        Console.WriteLine("List as many responses you can to the following prompt");
        Console.WriteLine($"-- {_prompts[randomNumber]} --");
        Console.Write("You may begin after loading");
        base.shortLoader();

        DateTime futureTime = DateTime.Now.AddSeconds(seconds);

        while (DateTime.Now < futureTime)
        {

            Console.Write(">");
            string answer = Console.ReadLine();

            answers.Add(answer);

            Thread.Sleep(1000);
        }
        
    }
    
}