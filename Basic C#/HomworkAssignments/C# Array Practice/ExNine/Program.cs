using System;
namespace ExNine;

public class Program
{
    public static void Main(string[] args)
    {
        int row1, row2, column1, column2;

        Console.WriteLine("Input the rows and columns of first matrix: ");
        Console.Write("Row: ");
        row1 = int.Parse(Console.ReadLine());
        Console.Write("Column: ");
        column1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Input the rows and columns of second matrix: ");
        Console.Write("Row: ");
        row2 = int.Parse(Console.ReadLine());
        Console.Write("Column: ");
        column2 = int.Parse(Console.ReadLine());

        int[,] matrix1 = new int[row1, column1];
        int[,] matrix2 = new int[row2, column2];
        int[,] resultMatrix = new int[row1, column2];

        Console.WriteLine("Input elements in the first matrix: ");
        for (int i = 0; i < row1; i++)
        {
            for (int j = 0; j < column1; j++)
            {
                Console.Write($"Element: [{i}][{j}]: ");
                matrix1[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("Input elements in the second matrix: ");
        for (int i = 0; i < row2; i++)
        {
            for (int j = 0; j < column2; j++)
            {
                Console.Write($"Element: [{i}][{j}]: ");
                matrix2[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("\nThe First matrix is: ");

        for (var i = 0; i < row1; i++)
        {
            for (var j = 0; j < column1; j++)
            {
                Console.Write(matrix1[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("The Second matrix is: ");

        for (var i = 0; i < row2; i++)
        {
            for (var j = 0; j < column2; j++)
            {
                Console.Write(matrix2[i, j] + " ");
            }
            Console.WriteLine();
        }

        for (var i = 0; i < row1; i++)
        {
            for (var j = 0; j < column2; j++)
            {
                for (var k = 0; k < row2; k++)
                {
                    resultMatrix[i, j] += matrix1[i, k]  *  matrix2[k, j];
                }
            }
        }
        
        Console.WriteLine("The multiplication of two matrix is: ");

        for (var i = 0; i < row1; i++)
        {
            for (var j = 0; j < column2; j++)
            {
                Console.Write(resultMatrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
