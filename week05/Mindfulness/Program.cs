using System;
using System.Diagnostics;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.Clear();

            Console.Write($@"
        Menu Options:
            1. Start Breathing Activity
            2. Start Reflecting Activity
            3. Start Listing Activity
            4. Quit
        ");
            Console.Write("Select a choice from the menu: ");
            int choice = int.Parse(Console.ReadLine());

            Console.Clear();

            Determine(choice);

            if (choice == 4)
            {
                Console.Clear();
                Console.WriteLine("Thank you for playing!");
                running = false;
            }

        }
    }

    static void Determine(int choice)
    {
        if (choice == 1)
        {
            bool runningBreathingact = true;

            while (runningBreathingact)
            {
                Breathing breathingActivityStart = new Breathing();
                breathingActivityStart.shortLoader();
                breathingActivityStart.PrintOutIntroMessage();

                Console.Write("Do you wanna do it again? Press enter to continue or type 'quit' to exit ");
                string answer = Console.ReadLine();

                if (answer == "quit")
                {
                    runningBreathingact = false;
                }

            }


        }
        else if (choice == 2)
        {
            while (true)
            {
                Reflection reflect = new Reflection();
                reflect.DisplayRandomPrompt();

                Console.Write("Do you wanna do it again? Press enter to continue or type 'quit' to exit ");
                string answer = Console.ReadLine();

                if (answer == "quit")
                {
                    break;
                }

            }


        }
        else if (choice == 3)
        {
            while (true)
            {

                Listing listingActivity = new Listing();
                listingActivity.StartProgram();

                Console.Write("Do you wanna do it again? Press enter to continue or type 'quit' to exit ");
                string answer = Console.ReadLine();

                if (answer == "quit")
                {
                    break;
                }
            
            }
        }
    }

}
