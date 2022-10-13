using System;
namespace ExEight;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter sugar level: ");
        int sugarLevel = int.Parse(Console.ReadLine());

        if (sugarLevel < 90)
        {
            Console.WriteLine("Low sugar");
        }
        else if (sugarLevel < 130)
        {
            Console.WriteLine("Normal");
        }
        else if (sugarLevel < 140)
        {
            Console.WriteLine("Medium");
        }
        else if (sugarLevel < 170)
        {
            Console.WriteLine("High sugar");
        }
        else
        {
            Console.WriteLine("You are a very high Sugar Patient");
        }
    }
}
