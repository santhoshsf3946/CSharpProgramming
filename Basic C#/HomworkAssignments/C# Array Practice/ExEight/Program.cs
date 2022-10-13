using System;
namespace ExEight;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Input the size of the square matrix (less than 5): ");
        int size = int.Parse(Console.ReadLine());

        int[,] matrix1 = new int[size, size];
        int[,] matrix2 = new int[size, size];

        Console.WriteLine("Input elements in the first matrix: ");
        for (var i = 0; i < size; i++)
        {
            for (var j = 0; j < size; j++)
            {
                Console.Write($"Element [{i}][{j}]: ");
                matrix1[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("Input elements in the second matrix: ");
        for (var i = 0; i < size; i++)
        {
            for (var j = 0; j < size; j++)
            {
                Console.Write($"Element [{i}][{j}]: ");
                matrix2[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("\nThe First matrix is: ");

        for (var i = 0; i < size; i++)
        {
            for (var j = 0; j < size; j++)
            {
                Console.Write(matrix1[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("The Second matrix is: ");

        for (var i = 0; i < size; i++)
        {
            for (var j = 0; j < size; j++)
            {
                Console.Write(matrix2[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("The Addition of two matrix is: ");

        for (var i = 0; i < size; i++)
        {
            for (var j = 0; j < size; j++)
            {
                Console.Write(matrix1[i, j] + matrix2[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
