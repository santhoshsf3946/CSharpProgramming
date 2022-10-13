using System;
namespace ExTwo;

public class Program
{
    public static void Main(string[] args)
    {
        double sum = 0, average;

        for (var i = 1; i <= 10; i++)
        {
            Console.Write($"Enter number {i}: ");
            sum += int.Parse(Console.ReadLine());
        }

        average = sum / 10;

        Console.WriteLine($"\n\tSum = {sum}");
        Console.WriteLine($"\tAverage = {average}");
    }
}
