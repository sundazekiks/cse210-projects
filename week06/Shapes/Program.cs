using System;

class Program
{
    static void Main(string[] args)
    {
        Square s = new Square(5, "blue");
        Console.WriteLine(s.GetArea());
        Console.WriteLine(s.GetColor());

        Rectangle r = new Rectangle(8, 4, "blue");
        Console.WriteLine(r.GetArea());
        Console.WriteLine(r.GetColor());

        Circle c = new Circle(4, "red");
        Console.WriteLine(c.GetArea());
        Console.WriteLine(c.GetColor());
    }
}