namespace Interfaces.Shape;

public class Triangle : IShape, IPrinter
{
    public double A { get; set; }

    public double B { get; set; }
    public double C { get; set; }

    public double GetArea()
    {
        var p = (A + B + C) / 2;

        return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
    }

    public double GetPerimeter()
    {
        return A + B + C;
    }

    public void Print()
    {
        Console.WriteLine($"{A} {B} {C}");
    }
}