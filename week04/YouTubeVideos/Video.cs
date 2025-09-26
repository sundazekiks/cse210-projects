using System;
using System.Data;

public class Video
{
    private string _title;
    private string _author;
    private int _vidLength;
    private List<Comment> comments;

    public Video(string title, string author, int vidLength)
    {
        _title = title;
        _author = author;
        _vidLength = vidLength;

        comments = new List<Comment>();
    }



    public void pushToCommentsList(Comment c)
    {
        comments.Add(c);
    }

    public void PrintOut()
    {
        foreach (Comment b in comments)
        {
            b.PrintOut();
        }
    }

    public void PrintOutVideo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Video Length: {_vidLength}");
        Console.WriteLine(" ");
    }

}