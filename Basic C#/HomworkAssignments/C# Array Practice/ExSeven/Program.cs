using System;
namespace ExSeven;

public class Program
{
    public static void Main(string[] args)
    {
        int[,] matrix = new int[3, 3];

        Console.WriteLine("Input elements in the matrix: ");

        for (var i = 0; i < 3; i++)
        {
            for (var j = 0; j < 3; j++)
            {
                Console.Write($"Element [{i}][{j}]: ");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("The matrix is: ");

        for (var i = 0; i < 3; i++)
        {
            for (var j = 0; j < 3; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
