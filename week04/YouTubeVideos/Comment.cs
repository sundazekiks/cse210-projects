using System;


public class Comment
{
    private string _name;
    private string _comment;

    public Comment(string name, string text)
    {
        _name = name;
        _comment = text;
    }

    public void PrintOut()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"comment: {_comment}");
         Console.WriteLine(" ");
    }
}