using System;

public class Activity
{

    public void StartLoader()
    {
        for (int i = 3; i != 0; i--)
        {
            Console.Write($"\rStarting in {i}");
            Thread.Sleep(1000);
        }

        Console.Write("\r                    ");
    }
    public void veryShortLoader()
    {
        string[] symbols = { "-", "\\", "|", "/" };

        for (int i = 0; i < 1; i++)
        {
            foreach (var symbol in symbols)
            {
                Console.Write($"\r {symbol}");
                Thread.Sleep(100);
            }
            Console.Write($"\r  ");
        }
        Console.WriteLine(' ');

    }


    public void shortLoader()
    {
        string[] symbols = { "-", "\\", "|", "/" };

        for (int i = 0; i < 5; i++)
        {
            foreach (var symbol in symbols)
            {
                Console.Write($"\r {symbol}");
                Thread.Sleep(200);
            }
            Console.Write($"\r  ");
        }
        Console.WriteLine(' ');

    }
   public void longLoader()
    {
        string[] symbols = { "-", "\\", "|", "/" };

        for (int i = 0; i < 10; i++)
        {
            foreach (var symbol in symbols)
            {
                Console.Write($"\r {symbol}");
                Thread.Sleep(200);
            }
            
            Console.Write($"\r ");
        }

        Console.WriteLine(' ');
   }
}