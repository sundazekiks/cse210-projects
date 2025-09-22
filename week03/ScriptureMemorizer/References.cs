
public class References
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public References()
    {
        _book = "John";
        _chapter = 3;
        _verse = 16;
    }
    public References(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }
    public References(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    public string GetReference()
    {
        if (_endVerse != 0)
        {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verse}";
        }
    }

    
    public void DisplayScripture()
    {
        Console.WriteLine($"{_book} {_chapter}:{_verse}-{_endVerse}");
    }

    
}