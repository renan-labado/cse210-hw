using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Shape square = new Square(4, "blue");

        Shape rectangle = new Rectangle(5, 4, "black");

        Shape circle = new Circle(2, "blue");

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();
            Console.WriteLine($"The {color} shape has an area of {area} \n");
        }
    }
}