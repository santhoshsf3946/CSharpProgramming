using System;
namespace Question6;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("============= Matrix Addition =============\n");

        int[,] matrix1 = new int[3, 3];
        int[,] matrix2 = new int[3, 3];
        int[,] sumMatrix = new int[3, 3];

        Console.WriteLine("Enter first matrix elements: ");
        GetValues(ref matrix1);
        PrintMatrix(matrix1);


        Console.WriteLine("Enter second matrix element: ");
        GetValues(ref matrix2);
        PrintMatrix(matrix2);

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                sumMatrix[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }

        Console.WriteLine("Addition two matrix: ");
        PrintMatrix(sumMatrix);
        
        void GetValues(ref int[,] matrix)
        {
            for (var i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Enter element [{i}, {j}]: ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        
        void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("");
        }
    }
}