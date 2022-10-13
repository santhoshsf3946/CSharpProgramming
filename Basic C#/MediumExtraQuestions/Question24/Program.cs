using System;
namespace Question24;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("================== House ==================\n");

        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine();

        int row = number % 2 != 0 ? row = number : row = number - 1;
        
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < number; j++)
            {
                if (i + j == row / 2 || i + j == (number % 2 != 0 ? row / 2 + i * 2 : row / 2 + i * 2 + 1) || i + j == row / 2 + j * 2 || i + j == row / 2 + number - 1)
                {
                    Console.Write("* ");
                }
                else
                {
                    Console.Write("- ");
                }
            }
            Console.WriteLine();
        }
    }
}
