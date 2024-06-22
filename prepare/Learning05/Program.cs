using System;
using System.Security.AccessControl;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square = new Square("red", 2);
        shapes.Add(square);

        Rectangle rectangle = new Rectangle("green", 3, 3.5);
        shapes.Add(rectangle);

        Circle circle = new Circle("blue", 2);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();

            double area = shape.GetArea();

            Console.WriteLine($"The {shape} is {color}, and has an area of {area}.");
        }
    }
}