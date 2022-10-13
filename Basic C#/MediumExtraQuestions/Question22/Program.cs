using System;
namespace Question22;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("================= Sunglasses =================\n");

        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine();

        for (int i = 0; i < number; i++)
        {
            for (int j = 0; j < number * 4 + number; j++)
            {
                if (i == 0 || j == 0 || i == number - 1 || j == number * 4 + number - 1 || j == number * 2 - 1 || j == number * 2 + number)
                {
                    if (number * 2 <= j && j <= number * 2 + number - 1 && (i == 0 || i == number - 1))
                    {
                        Console.Write("  ");
                    }
                    else
                    {
                        Console.Write("* ");
                    }         
                }
                else if (number * 2 <= j && j <= number * 2 + number - 1)
                {
                    if (Math.Round((double) ((number - 1) / 2), 0, MidpointRounding.ToPositiveInfinity) == i)
                    {
                        Console.Write("| ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                else
                {
                    Console.Write("/ ");
                }
            }
            Console.WriteLine("\n");
        }
    }
}
