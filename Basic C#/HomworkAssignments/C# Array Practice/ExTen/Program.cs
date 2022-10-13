using System;
namespace ExTen;

public class Program
{
    public static void Main(string[] args)
    {
        int row, column;

        Console.WriteLine("Input the rows and columns of the matrix: ");
        Console.Write("Row: ");
        row = int.Parse(Console.ReadLine());
        Console.Write("Column: ");
        column = int.Parse(Console.ReadLine());

        int[,] matrix = new int[row, column];
        int[,] transpose = new int[column, row];

        Console.WriteLine("Input the elements of the matrix: ");

        for (var i = 0; i < row; i++)
        {
            for (var j = 0; j < column; j++)
            {
                Console.Write($"Element: [{i}][{j}]: ");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("\nThe matrix is: ");

        for (var i = 0; i < row; i++)
        {
            for (var j = 0; j < column; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("The Transpose of a matrix is: ");

        for (var i = 0; i < row; i++)
        {
            for (var j = 0; j < column; j++)
            {
                Console.Write(matrix[j, i] + " ");
            }
            Console.WriteLine();
        }
    }
}
