using System;
namespace InerfaceApplication;

public class Program
{
    public static void Main(string[] args)
    {
        Draw rectangle = new Draw();

        rectangle.Length = 50;
        rectangle.Breadth = 10;

        rectangle.CalculateArea();
    }
}
