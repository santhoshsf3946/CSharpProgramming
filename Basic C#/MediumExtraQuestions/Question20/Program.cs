using System;
namespace Question20;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("================= Rhombus Made of Stars =================\n");

        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine();

        for (int i = 0; i < number; i++)
        {
            for (int j = number - i - 1; j > 0; j--)
            {
                Console.Write("  ");
            }
            for (int j = 0; j < i * 2 + 1; j++)
            {
                if (j % 2 == 0)
                {
                    Console.Write("* ");
                }
                else
                {
                    Console.Write("  ");
                }
            }
            Console.WriteLine();
        }
        for (int i = 0; i < number - 1; i++)
        {
            for (int j = i + 1; j > 0; j--)
            {
                Console.Write("  ");
            }
            for (int j = 0; j < (number - i - 1) * 2; j++)
            {
                if (j % 2 == 0)
                {
                    Console.Write("* ");
                }
                else
                {
                    Console.Write("  ");
                }
            }
            Console.WriteLine();
        }
    }
}
