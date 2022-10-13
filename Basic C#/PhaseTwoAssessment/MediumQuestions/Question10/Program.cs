using System;
namespace Question10;

public class Program
{
    public static void Main(string[] args)
    {
        int n = 18;

        Console.WriteLine("============= Rectangle Pattern =============\n");
        
        for (int i = 0; i < n / 3; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i == 0 || i == n / 3 - 1 || j == 0 || j == n - 1)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}
