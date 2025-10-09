public class Rectangle : Shape
{
    private double _Length;
    private double _Width;

    public Rectangle(double length, double width, string color) : base(color)
    {
        _Length = length;
        _Width = width;
    }

    public override double GetArea()
    {
        return _Length * _Width;
    }
}