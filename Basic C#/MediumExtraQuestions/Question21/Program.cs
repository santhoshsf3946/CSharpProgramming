using System;
namespace Question21;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("============== Christmas Tree ==============\n");

        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine();

        for (int i = 0; i <= number; i++)
        {
            for (int j = number - i; j > 0; j--)
            {
                Console.Write(" ");
            }
            for (int j = 0; j < i; j++)
            {
                Console.Write("*");
            }
            Console.Write(" | ");
            for (int j = 0; j < i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        Console.WriteLine();    
    }
}
