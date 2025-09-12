public class WriteEntryC
{
    public string _date;
    public string _question;
    public string _entry;

    // Method to save the journal entry to a file
    public void SaveToFile()
    {
        string filename = "/Users/travisabuton/Desktop/Projects/cse210-projects/week02/Journal/journal.txt";
        using (StreamWriter outputFile = new StreamWriter(filename, true))
        {
            outputFile.WriteLine($"{_date}|{_question}|{_entry}");
        }
    }
}