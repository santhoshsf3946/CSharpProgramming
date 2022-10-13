using System;
namespace ExTwo;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter input count: ");
        int count = int.Parse(Console.ReadLine());
        int sumOfSquares = 0, i = 1;

        Console.Write($"Number from 1 to {count}: ");
        while (i <= count)
        {
            Console.Write(i + " ");
            sumOfSquares += i * i;
            i++;
        }

        Console.WriteLine($"\nSum of Squares: {sumOfSquares}");
    }
}
