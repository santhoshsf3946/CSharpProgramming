using System;
namespace ExThree;

public class Program
{
    public static void Main(string[] args)
    {
        int f1 = 0, f2 = 1, f3 = 0, i = 0;

        Console.WriteLine("=============== Fibonacci Series ===============\n");

        Console.Write("Enter the number of terms to display: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write($"Here is the Fibonacci series upto {n} terms: {f1} {f2} ");

        do
        {
            f3 = f1 + f2;
            f1 = f2;
            f2 = f3;
            Console.Write(f3 + " ");
            i++;
        } while (i < n - 2);
    }
}
