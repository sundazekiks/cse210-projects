using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string[] scripture = ScripturePassage();

        string book = scripture[0].Split(" ")[0].Replace("-", " ");
        int chapter = int.Parse(scripture[0].Split(" ")[1].Split(":")[0]);
        string[] verses = scripture[0].Split(" ")[1].Split(":")[1].Split("-");
        int startVerse = int.Parse(verses[0]);
        int endVerse = int.Parse(verses.Length > 1 ? verses[1] : "0");
        string[] words = scripture[1].Split(" ");

        References references = new References();
        bool deter = true;
        
        if (endVerse != 0)
        {
            references = new References(book, chapter, startVerse, endVerse);
        }
        else
        {
            references = new References(book, chapter, startVerse);
        }

        Scripture scripturePassage = new Scripture(references, words);

        do
        {
            Console.WriteLine(scripturePassage.GetDisplayText());
            Console.WriteLine("Please press enter to continue or type 'quit' to exit");
            string answer = Console.ReadLine();

            if (answer == "quit")
            {
                deter = false;
            }
            Console.Clear();

            scripturePassage.HideRandomWords(words.Length);

        } while (deter);


    }

    // Generate a scripture passage 
    static string[] ScripturePassage()
    {
        string filename = Path.Combine("..", "..", "..", "scriptures.txt");
        string[] words = System.IO.File.ReadAllLines(filename);
        int fileLength = words.Length;
        Random rand = new Random();

        int genRan = rand.Next(1, fileLength);

        string scripturePass = words[genRan];

        string[] wordsList = scripturePass.Split("_");

        return wordsList;
    }
    


}