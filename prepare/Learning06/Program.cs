using System;

class Program
{
    static void Main(string[] args)
    {
        Square s1 = new Square("Purple", 5);
        Square s2 = new Square("Yellow", 2.5);
        Rectangle r1 = new Rectangle("Blue", 4.3, 6);
        Rectangle r2 = new Rectangle("Red", 2.2, 9.2);
        Circle c1 = new Circle("Brown", 3.5);
        Circle c2 = new Circle("Orange", 5.6);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(s1);
        shapes.Add(s2);
        shapes.Add(r1);
        shapes.Add(r2);
        shapes.Add(c1);
        shapes.Add(c2);

        foreach (Shape s in shapes)
        {
            Console.WriteLine($"Color is {s.GetColor()} and area is {s.GetArea()}");
        }
    }
}