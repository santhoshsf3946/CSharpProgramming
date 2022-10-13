using System;
namespace Question1;

public class Program
{
    public static void Main(string[] args)
    {
        int number;

        Console.WriteLine("\n=========== Mathematics Table ===========\n");

        Console.Write("Enter the number: ");
        number = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 20; i++)
        {
            Console.WriteLine($"\t{number, 2} * {i, 2} = {i * number, 3}");
        }
    }
}
