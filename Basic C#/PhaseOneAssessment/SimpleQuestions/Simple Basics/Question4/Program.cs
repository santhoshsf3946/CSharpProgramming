using System;
namespace Question4;

public class Program
{
    public static void Main(string[] args)
    {
        double currency;

        Console.WriteLine("================ Currency Converter ================\n");      

        Console.Write("Enter the amount in INR: ");
        currency = double.Parse(Console.ReadLine());

        Console.WriteLine($"\n\tUSD = {Math.Round(currency * 0.0122, 2)}");
        Console.WriteLine($"\tEUR = {Math.Round(currency * 0.0127, 2)}");
        Console.WriteLine($"\tCNY = {Math.Round(currency * 0.0879, 2)}\n");
    }
}