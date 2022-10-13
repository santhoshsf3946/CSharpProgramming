using System;
namespace ExSeven;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter number: ");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine("\n");

        for (int i = 0; i < num; i++)
        {
            for (int j = num - i; j > 1; j--)
            {
                Console.Write(" ");
            }
            for (var j = 0; j <= i; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
