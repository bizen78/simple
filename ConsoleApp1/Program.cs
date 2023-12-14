using System;

public class Circle
{
    public readonly double PI;
    public readonly double Radius;

    public Circle(double radius)
    {
        PI = 3.14159; // Initializing readonly variable inside constructor
        Radius = radius; // Another readonly variable initialization inside constructor
    }

    public double CalculateArea()
    {
        return PI * Radius * Radius;
    }
}

public class Program
{
    public static void Main()
    {
        Circle c = new Circle(5);
        Console.WriteLine($"Area of the circle with radius 5 is: {c.CalculateArea()}");

        // The following line would produce a compile error since PI is readonly
        // c.PI = 3.14; 
    }
}
