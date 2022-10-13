using System;
namespace ExSix;

public class MyClass
{
    public static void Main(string[] args)
    {
        Console.Write("Price - ");
        double price = double.Parse(Console.ReadLine());

        double total = price + price * 0.18;

        Console.WriteLine($"Total = {total}");
    }
}