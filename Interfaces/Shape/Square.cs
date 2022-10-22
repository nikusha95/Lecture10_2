namespace Interfaces.Shape;

public class Square : IShape, IPrinter
{
    public double Side { get; set; }

    public double GetArea()
    {
        return Side * Side;
    }

    public double GetPerimeter()
    {
        return Side * 4;
    }

    public void Print()
    {
        Console.WriteLine($"Side {Side}");
    }
}