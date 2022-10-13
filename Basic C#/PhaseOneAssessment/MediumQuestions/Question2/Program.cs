using System;
namespace Question2;

public class Program
{
    public static void Main(string[] args)
    {
        int terms, f1 = 0, f2 = 1, f3;

        Console.WriteLine("============== Fibonacci Series ==============\n");

        Console.Write("Input the number of terms to display: ");
        terms = int.Parse(Console.ReadLine());

        Console.WriteLine($"Here is the Fibonacci series upto {terms} terms: ");

        if (terms >= 2)
        {
            Console.Write(f1 + " " + f2);

            for (int i = 0; i < terms - 2; i++)
            {
                f3 = f1 + f2;
                f1 = f2;
                f2 = f3;
                Console.Write(" " + f3);
            }
        }
        else
        {
            Console.WriteLine("Terms must be greater than or equal to 2");
        }
    }
}
