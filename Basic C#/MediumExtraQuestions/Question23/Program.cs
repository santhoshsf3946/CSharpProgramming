using System;
namespace Question23;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("================== House ==================\n");

        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine();

        int roof = (int) Math.Round((double) number / 2, 0, MidpointRounding.ToPositiveInfinity);

        for (int i = 0; i < roof; i++)
        {
            for (int j = roof - i - 1; j > 0; j--)
            {
                Console.Write("- ");
            }
            for (int j = 0; j < (number % 2 == 0 ? i * 2 + 2 : i * 2 + 1); j++)
            {
                Console.Write("* ");
            }
            for (int j = roof - i - 1; j > 0; j--)
            {
                Console.Write("- ");
            }
            Console.WriteLine();
        }

        for (int i = 0; i < number / 2; i++)
        {
            for (int j = 0; j < number; j++)
            {
                if (j == 0 || j == number - 1)
                {
                    Console.Write("| ");
                }
                else
                {
                    Console.Write("* ");
                }
                
            }
            Console.WriteLine();
        }
    }
}
