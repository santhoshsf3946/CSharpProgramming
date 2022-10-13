using System;
namespace Question12;

public class Program
{
    public static void Main(string[] args)
    {
        int sumOfSquare = 0, length, number;

        Console.WriteLine("============= Sum of Square ==============\n");

        Console.Write("Enter number of elements: ");
        length = int.Parse(Console.ReadLine());

        for (int i = 0; i < length; i++)
        {
            Console.Write("Enter value: ");
            number = int.Parse(Console.ReadLine());
            sumOfSquare += number * number;
        }

        Console.WriteLine("Sum of squares: " + sumOfSquare);
    }
}