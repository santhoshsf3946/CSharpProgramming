using System;
namespace ExTen;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=========== Prime Number ===========");

        Console.Write("Enter number: ");
        int num = int.Parse(Console.ReadLine());

        int count = 0;
        for (var i = 1; i <= num; i++)
        {
            if (num % i == 0)
            {
                count++;
            }
        }
        if (count == 2)
        {
            Console.WriteLine($"{num} is a Prime number");
        }
        else
        {
            Console.WriteLine($"{num} is not a Prime number");
        }
    }
}
