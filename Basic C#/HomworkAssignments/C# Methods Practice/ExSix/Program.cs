using System;
namespace ExSix;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("================= Factorial =================\n");

        Console.Write("Enter a number a number: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine($"The Factorial of {number}! is {(Factorial(number))}");

        int Factorial(int value)
        {
            if (value == 1)
            {
                return 1;
            }
            else
            {
                return value * Factorial(value - 1);
            }
        }
    }
}
