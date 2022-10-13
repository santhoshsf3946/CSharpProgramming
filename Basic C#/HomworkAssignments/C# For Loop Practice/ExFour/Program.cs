using System;
namespace ExFour;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("\n============== Multiplication Table ==============\n");

        Console.Write("Input the number (Table to be calculated): ");
        int num = int.Parse(Console.ReadLine());

        for (var i = 1; i <= 10; i++)
        {
            Console.WriteLine($"\t{num} X {i} = {num * i}");
        }

        Console.WriteLine("\n");
    }
}
