using System;

class Program
{
    static void Main(string[] args)
    {
        Video a = new Video("Travesty", "Travis", 200000);
        Comment a1 = new Comment("Jenna", "interesting!");
        Comment a2 = new Comment("Mark", "Dope!");
        Comment a3 = new Comment("Ray", "Cool");

        a.pushToCommentsList(a1);
        a.pushToCommentsList(a2);
        a.pushToCommentsList(a3);

        a.PrintOutVideo();
        Console.WriteLine("Comments: ");
        a.PrintOut();

        Video b = new Video("How to center a div", "Bro Code", 10000);
        Comment b1 = new Comment("Collene", "Thanks I know how to center it now");
        Comment b2 = new Comment("Joshua", "Cool, Thanks dude! Appreciate it!");
        Comment b3 = new Comment("Jay", "Awesome keep it up");

        b.pushToCommentsList(b1);
        b.pushToCommentsList(b2);
        b.pushToCommentsList(b3);

        b.PrintOutVideo();
        Console.WriteLine("Comments: ");
        b.PrintOut();
        
        Video c = new Video("Javascript Basics", "JS Mastery", 100000);
        Comment c1 = new Comment("ProCode", "On my way to greatness!");
        Comment c2 = new Comment("Hayden", "Cooool!! Nice!");
        Comment c3 = new Comment("June", "JS Basics!");

        c.pushToCommentsList(c1);
        c.pushToCommentsList(c2);
        c.pushToCommentsList(c3);

        c.PrintOutVideo();
        Console.WriteLine("Comments: ");
        c.PrintOut();
    }
}