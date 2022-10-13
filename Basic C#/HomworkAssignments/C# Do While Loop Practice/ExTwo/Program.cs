using System;
namespace ExTwo;

public class Program
{
    public static void Main(string[] args)
    {
        int number = 0, sum = 0;

        do
        {
            sum += number;
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());
        } while (number >= 0);

        Console.WriteLine($"\nSum of the integers: {sum}");
    }
}
