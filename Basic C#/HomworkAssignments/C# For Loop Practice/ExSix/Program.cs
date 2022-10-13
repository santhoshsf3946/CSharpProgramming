using System;
namespace ExSix;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Pattern Printing (Right Angled triangle)\n");

        Console.Write("Enter number: ");
        int length = int.Parse(Console.ReadLine());
        Console.WriteLine("\n");

        for (var i = 0; i < length; i++)
        {
            for (var j = 0; j <= i; j++)
            {
                Console.Write("*   ");
            }
            Console.WriteLine("\n");
        }
    }
}
