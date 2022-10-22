// See https://aka.ms/new-console-template for more information


using System.Threading.Channels;
using Interfaces.Shape;

Square square = new();

square.Side = 10;


Console.WriteLine(square.GetArea());
Console.WriteLine(square.GetPerimeter());
square.Print();

Triangle t = new Triangle
{
    A = 3,
    B = 4,
    C = 5
};

IShape shape = new Square();
shape = new Triangle();