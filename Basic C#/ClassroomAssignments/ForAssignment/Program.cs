using System;
namespace ForAssignment;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Even numbers from 0 to 25:");
        for (int i = 0; i < 25; i = i + 2)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("\n=====================================================\n");

        Console.Write("Enter initial value: ");
        int initial = int.Parse(Console.ReadLine());

        Console.Write("Enter final value: ");
        int final = int.Parse(Console.ReadLine());

        int total = 0;
        for (var i = initial; i <= final; i++)
        {
            total += i * i;
        }
        Console.WriteLine($"Sum of values from {initial} to {final}: {total}");
    }
}
