using System;
namespace ExFour;

public class Program
{
    public static void Main(string[] args)
    {
        int length;
        Console.WriteLine("================= Fibonacci Series =================\n");

        Console.Write("Input number of Fibonacci Series: ");
        length = int.Parse(Console.ReadLine());
        Console.WriteLine();

        Console.WriteLine($"The Fibonacci series of 5 numbers is: ");
        generateFibonacci(length);

        void generateFibonacci(int count)
        {
            int f1 = 0, f2 = 1, f3;
            
            Console.Write(f1 + " " + f2);
            for (var i = 0; i < count - 2; i++)
            {
                f3 = f1 + f2;
                f1 = f2;
                f2 = f3;
                Console.Write(" " + f3);   
            }
        }
    }
}
