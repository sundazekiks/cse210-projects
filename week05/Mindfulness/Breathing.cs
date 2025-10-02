

public class Breathing : Activity
{
    private string _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    private string _prompt = "How long, in seconds, would you like for your session? ";

    public void PrintOutIntroMessage()
    {
        Console.Write($@"
        Welcome to the Breathing Actitvity

        {_description}

        ");
        Console.Write(_prompt);
        int seconds = int.Parse(Console.ReadLine());

        Console.Clear();
        SecondStepOfBreathingExercise(seconds);
    }

    public void sessionManager(int seconds)
    {
        int ActualSeconds = seconds * 1000;
        int secondsToBeLoggedIn = (ActualSeconds / 10000) * 1000;

        Console.WriteLine(secondsToBeLoggedIn);
        string test = Console.ReadLine();

        for (int i = secondsToBeLoggedIn; i > 0; i -= 1000)
        {
            for (int j = 4; j != 0; j--)
            {
                Console.Write($"\rBreathe in...{j}");
                Thread.Sleep(1000);
            }
            Console.Write("\rBreathe In....");
            Console.WriteLine(' ');

            for (int k = 6; k != 0; k--)
            {
                Console.Write($"\rBreathe out...{k}");
                Thread.Sleep(1000);
            }
            Console.Write("\rBreathe Out....");
            Console.WriteLine(' ');
            Console.WriteLine(' ');
        }

        Console.WriteLine("Well Done!!!");

        base.shortLoader();

        Console.WriteLine($"You have completed {ActualSeconds / 1000} seconds of the Breathing Activity!");
        base.longLoader();

    }

    public void SecondStepOfBreathingExercise(int seconds)
    {
        Console.WriteLine("Get Ready...");
        base.shortLoader();
        sessionManager(seconds);
    }

}