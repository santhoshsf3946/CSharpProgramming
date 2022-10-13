using System;
namespace Question7;

public class Program
{
    public static void Main(string[] args)
    {
        int number;

        Console.Write("Enter a number: ");
        number = int.Parse(Console.ReadLine());

        if (number < 100)
        {
            Console.WriteLine("Less than 100");
        }
        else if (number <= 200)
        {
            Console.WriteLine("Between 100 and 200");
        }
        else
        {
            Console.WriteLine("Greater than 200");
        }
    }
}