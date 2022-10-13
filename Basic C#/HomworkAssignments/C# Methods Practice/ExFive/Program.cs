using System;
namespace ExFive;

public class Program
{
    public static void Main(string[] args)
    {
        int number, factorCount = 0;

        Console.Write("Input a number: ");
        number = int.Parse(Console.ReadLine());

        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                factorCount++;
            }
        }

        if (factorCount == 2)
        {
            Console.WriteLine($"{number} is a prime number");
        }
        else
        {
            Console.WriteLine($"{number} is not a prime number");
        }
    }
}
