using System;
namespace Question9;

public class Program
{
    public static void Main(string[] args)
    {
        int number;

        Console.Write("Enter a number: ");
        number = int.Parse(Console.ReadLine());

        for (int i = 0; i < number; i++)
        {
            for (int j = number - i - 1; j > 0; j--)
            {
                Console.Write(" ");
            }
           
            Console.Write("".PadLeft(i * 2 + 1, '*'));
            Console.WriteLine();
        }
    }
}
