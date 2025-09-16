using System;

class Program
{
    static void Main(string[] args)
    {
        Fractions f = new Fractions();
        Fractions f2 = new Fractions(1);
        Fractions f3 = new Fractions(6, 7);

        Fractions f4 = new Fractions(5);
        Fractions f5 = new Fractions(3, 4);
        Fractions f6 = new Fractions(1, 3);

        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());
        Console.WriteLine(f5.GetFractionString());
        Console.WriteLine(f5.GetDecimalValue());
        Console.WriteLine(f6.GetFractionString());
        Console.WriteLine(f6.GetDecimalValue());
    }
}