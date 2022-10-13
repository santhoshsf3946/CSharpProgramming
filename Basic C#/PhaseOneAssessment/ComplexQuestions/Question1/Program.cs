using System;
namespace Question1;

public class Program
{
    public static void Main(string[] args)
    {
        int[,] matrix1 = new int[2, 3];
        int[,] matrix2 = new int[3, 2];
        int[,] resultmatrix = new int[2, 2];

        Console.WriteLine("============ Matrix Multiplication ============\n");

        Console.WriteLine("Enter the elements of the first matrix: ");
        GetValues(2, 3, ref matrix1);
        PrintMatrix(2, 3, matrix1);

        Console.WriteLine("Enter the elements of the second matrix: ");
        GetValues(3, 2, ref matrix2);
        PrintMatrix(3, 2, matrix2);

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                for (int k = 0; k < 3; k++)
                {
                    resultmatrix[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }

        Console.WriteLine("The multiplication of two matrix is: ");
        PrintMatrix(2, 2, resultmatrix);


        void PrintMatrix(int row, int column, int[,] matrix)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        void GetValues(int row, int column, ref int[,] matrix)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j  < column; j++)
                {
                    Console.Write($"Enter element[{i}][{j}]: ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}
