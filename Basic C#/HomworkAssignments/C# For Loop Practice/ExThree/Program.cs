using System;
namespace ExThree;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("==================== Cube of the Number ====================");

        Console.Write("Enter number of terms: ");
        int length = int.Parse(Console.ReadLine());

        for (var i = 1; i <= length; i++)
        {
            Console.WriteLine($"Number is: {i} and Cube of the number is: {i * i * i}");
        }
    }
}
