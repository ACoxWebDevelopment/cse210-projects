using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("green", 5);
       // Console.WriteLine(square.GetColor());
       // Console.WriteLine(square.GetArea());

        Rectangle rectangle = new Rectangle(3, 4, "red");
        //Console.WriteLine(rectangle.GetColor());
        //Console.WriteLine(rectangle.GetArea());

        Circle circle = new Circle(5, "blue");
        //Console.WriteLine(circle.GetColor());
        //Console.WriteLine(circle.GetArea());

        List<Shape> myList = new List<Shape>();
        myList.Add(square);
        myList.Add(rectangle);
        myList.Add(circle);

        foreach (Shape shape in myList)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }

    }
}