using System;
namespace ExFive;

public class Program
{
    public static void Main(string[] args)
    {
        int sum = 0;
        Console.WriteLine("\n========== Odd Natural Numbers Sum ==========\n\n");

        Console.Write("Input the number of terms: ");
        int num = int.Parse(Console.ReadLine());

        Console.Write("\nThe Odd numbers are: ");
        for (var i = 1; i <= num * 2; i += 2)
        {
            Console.Write(i);
            if (i != num * 2 - 1)
            {
                Console.Write(", ");
            }
            sum += i;
        }

        Console.WriteLine($"\n\nThe Sum of Natural Numbers upto 10 terms: {sum}\n");
    }
}
