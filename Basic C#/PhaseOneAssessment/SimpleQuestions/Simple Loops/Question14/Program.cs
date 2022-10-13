using System;
namespace Question14;

public class Program
{
    public static void Main(string[] args)
    {

        int number;

        Console.WriteLine("\n=========== Number Pattern Printing ===========\n");

        Console.Write("Enter a number: ");
        number = int.Parse(Console.ReadLine());

        for (int i = 1; i <= number; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(i);
            }
            Console.WriteLine();
        }
    }
}
