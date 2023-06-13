using System;

// MAIN PROGRAM

List<Shape> list = new List<Shape>();

Square square = new Square("blue", 4);

list.Add(square);

Rectangle rectangle = new Rectangle("yellow", 3, 2);

list.Add(rectangle);

Circle circle = new Circle("red", 2);

list.Add(circle);

Console.Clear();

foreach (Shape i in list)
{
    Console.WriteLine($"\n{i}: {i.getArea()}, {i.getColor()}");
}



// CLASSES

public abstract class Shape
{
    protected string _color;

    
    public Shape(string color)
    {
        _color = color;
    }


    public string getColor()
    {
        return _color;
    }
    

    public abstract double getArea();
}


public class Square : Shape
{
    private double _side;

    public Square(string color, double side) : base(color)
    {
        _side = side;
    }

    public override double getArea()
    {
        return _side * _side;
    }
}


public class Rectangle : Shape
{
    private double _length;
    private double _width;

    public Rectangle(string color, double length, double width) : base(color)
    {
        _length = length;
        _width = width;
    }

    public override double getArea()
    {
        return _length * _width;
    }
}


public class Circle : Shape
{
    private double _radius;

    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }

    public override double getArea()
    {
        return Math.PI * _radius * _radius;
    }
}