using System;

class Program
{
    static void Main(string[] args)
    {
        InterfaceMenu i = new InterfaceMenu();
        bool running = true;
        while (running)
        {
            Console.WriteLine(' ');
            Console.WriteLine("Hello World! This is the EternalQuest Project.");
            Console.WriteLine("Don't forget to hit save so you won't lose your data");
            i.getPoints();
            i.Menu();
            Console.Clear();
            i.chosenItem(i.choice());
            i.PointsRecorder();

            if(i.choice() == 6)
            {
                running = false;
            }
        }

        // i.Test();

        // Console.WriteLine(i.determineIfGoalsTxtFileIsEmpty());

    }
}