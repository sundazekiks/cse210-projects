using System;

public class Reflection : Activity
{

    private string _welcomeMessage = "Welcome to the Breathing Actitvity";
    private string _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

    private string[] _prompt = { "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless." };

    private string[] _followUpPrompts = { "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?" };

    private List<string> _answer = new List<string>();


    public void DisplayRandomPrompt()
    {

        Console.Write($@"
        {_welcomeMessage}
        
        {_description}

        ");

        Console.Write("How long, in seconds, would you like for your session? ");
        int answer = int.Parse(Console.ReadLine());


        base.veryShortLoader();
        BeginPrompts(answer);

        Console.WriteLine("Well done!");

        Console.WriteLine($"You have completed another {answer} seconds of the Reflecting Acitvity");
        base.shortLoader();
    }

    public void BeginPrompts(int seconds)
    {
        Random rand = new Random();
        int LengthofPromptsArray = _prompt.Length;
        int randomNumber = rand.Next(LengthofPromptsArray);

        Console.WriteLine(_prompt[randomNumber]);

        base.StartLoader();
        Console.WriteLine(" ");
        PromptGeneratorLoop(seconds);


    }

    public void PromptGeneratorLoop(int numberOfSeconds)
    {
        DateTime futureTime = DateTime.Now.AddSeconds(numberOfSeconds);

        while (DateTime.Now < futureTime)  
        {
            Random rnd = new Random();
            int LengthOfFollowUpPrompts = _followUpPrompts.Length;
            int randomNumber = rnd.Next(LengthOfFollowUpPrompts);

            Console.WriteLine($"{_followUpPrompts[randomNumber]}");
            string answer = Console.ReadLine();

            _answer.Add(answer);

            base.veryShortLoader();
        }

    }



}