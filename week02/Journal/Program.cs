using System;
using System.IO;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        // A variable for running the program
        bool runProgram = true;

        // This stores the the user's journal entry in the mean time
        List<(string Time, string Question, string Entry)> journalEntries = new List<(string, string, string)>();

        while (runProgram)
        {
            Console.WriteLine("Please select one of the following choices (number):");
            Console.WriteLine("1. Write a journal entry");
            Console.WriteLine("2. Display journal entries");
            Console.WriteLine("3. Load journal entries from a file");
            Console.WriteLine("4. Save journal entries to a file");
            Console.WriteLine("5. Quit");
            // Get the user's choice
            Console.WriteLine("What would you like to do?");
            Console.Write("> ");
            int choice = int.Parse(Console.ReadLine());




            switch (choice)
            {
                case 1:
                    Console.WriteLine("You chose to write a journal entry.");
                    // Code to write a journal entry
                    string filePath = Path.Combine("..", "..", "..", "questions.txt");
                    string[] lines = System.IO.File.ReadAllLines(filePath);

                    Random rand = new Random();
                    string response;

                    do
                    {
                        int index = rand.Next(lines.Length);
                        Console.WriteLine(lines[index]);
                        Console.Write("> ");
                        string journalEntry = Console.ReadLine();
                        // Get the current date and time
                        DateTime dateTime = DateTime.Now;
                        // Format the date and time as a string
                        string theCurrentTime = dateTime.ToShortDateString();
                        // Add the formatted entry to the list
                        journalEntries.Add((theCurrentTime, lines[index], journalEntry));
                        Console.WriteLine("Your entry has been recorded.");
                        Console.WriteLine("Type 'quit' to exit or press Enter to continue.");
                        response = Console.ReadLine();

                    } while (response != "quit");

                    break;
                case 2:
                    Console.WriteLine("You chose to display journal entries.");
                    // Code to display journal entries
                    Console.WriteLine("Here are your journal entries:");

                    // Loop through each entry in the list and print it
                    foreach (var line in journalEntries)
                    {
                        Console.WriteLine(line.Time);
                        Console.WriteLine(line.Question);
                        Console.WriteLine(line.Entry);
                        Console.WriteLine(); // Write an extra blank line between entries
                    }
                    break;
                case 3:
                    Console.WriteLine("You chose to load journal entries from a file.");
                    // Code to load journal entries from a file

                    string filename = Path.Combine("..", "..", "..", "journal.txt");
                    string[] fileLines = System.IO.File.ReadAllLines(filename);
                    int fileLength = fileLines.Length;


                    // Loop through each line in the file 
                    foreach (string line in fileLines)
                    {
                        string[] parts = line.Split('|');
                        if (parts.Length == 3)
                        {
                            FromLeadedFile fromLeadedFile = new FromLeadedFile();


                            Console.WriteLine(fromLeadedFile._date = parts[0]);
                            Console.WriteLine(fromLeadedFile._question = parts[1]);
                            Console.WriteLine(
                            fromLeadedFile._entry = parts[2]);
                            Console.WriteLine();

                        }
                    }


                    Console.WriteLine("Journal entries loaded from file.");
                    break;
                case 4:
                    Console.WriteLine("You chose to save journal entries to a file.");
                    // Code to save journal entries to a file
                    writeEntry(journalEntries);
                    journalEntries.Clear();
                    break;
                case 5:
                    Console.WriteLine("You chose to quit. Goodbye!");
                    // Code to quit the program
                    runProgram = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a number between 1 and 5.");
                    break;
            }
            Console.WriteLine(); // Print a blank line for better readability
        }
    }

    // Method to write a journal entry
    public static void writeEntry(List<(string Time, string Question, string Entry)> journalEntries)
    {
        // Implementation for writing a journal entry
        Console.WriteLine("Writing a journal entry...");

        foreach (var entry in journalEntries)
        {
            WriteEntryC writeEntryC = new WriteEntryC();
            writeEntryC._date = entry.Time;
            writeEntryC._question = entry.Question;
            writeEntryC._entry = entry.Entry;
            writeEntryC.SaveToFile();
        }



    }
    
    

}