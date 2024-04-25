using System;
using Tasks;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter length: ");
        double length = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter width: ");
        double width = double.Parse(Console.ReadLine());

        Rectangle rectangle = new Rectangle(length, width);
        Console.Write($"\nRectangle area is: {rectangle.getArea()}");
        Console.WriteLine($"\nRectangle perimeter is: {rectangle.getPerimeter()}");
    }
}