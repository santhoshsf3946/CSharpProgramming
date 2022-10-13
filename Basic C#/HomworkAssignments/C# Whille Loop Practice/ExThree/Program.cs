using System;
namespace ExThree;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("================= Fibonacci Series =================\n");
        Console.Write("Input number of terms to display: ");
        int n = int.Parse(Console.ReadLine());
        int f1 = 0, f2 = 1, f3, i = 0;

        Console.WriteLine($"Here is the Fibonacci series upto {n} terms:");
        Console.Write($"{f1} {f2} ");

        while (i < n - 2)
        {
            f3 = f1 + f2;
            f1 = f2;
            f2 = f3;
            Console.Write(f3 + " ");
            i++;
        }
    }
}
