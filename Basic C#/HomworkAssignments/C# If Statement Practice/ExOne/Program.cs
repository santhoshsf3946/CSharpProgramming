using System;
namespace ExOne;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a Number: ");
        int number = int.Parse(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.WriteLine($"{number} is an even integer");
        } else {
            Console.WriteLine($"{number} is an odd integer");
        }
    }
}
