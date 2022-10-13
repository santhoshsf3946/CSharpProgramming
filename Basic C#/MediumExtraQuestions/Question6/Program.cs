using System;
namespace Question6;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=========== Transportation Price ===========\n");

        Console.Write("Enter number of kilometers to travel: ");
        int kilometers = int.Parse(Console.ReadLine());

        Console.Write("Enter day or night: ");
        string time = Console.ReadLine().Trim().ToLower();

        double price;

        if (kilometers <= 20)
        {
            price = 0.7;
            if (time == "day")
            {
                price += kilometers * 0.79;
                Console.WriteLine($"Day time taxi travel price for {kilometers} km is: {Math.Round(price, 1)}");
            }
            else if (time == "night")
            {
                price += kilometers * 0.9;
                Console.WriteLine($"Night time taxi travel price for {kilometers} km is: {Math.Round(price, 1)}");
            }
            else
            {
                Console.WriteLine("Invalid Timing !");
            }
        }
        else if (kilometers <= 100)
        {
            price = kilometers * 0.09;
            Console.WriteLine($"Bus travel price for {kilometers} km is: {Math.Round(price, 1)}");
        }
        else
        {
            price = kilometers * 0.06;
            Console.WriteLine($"Train travel price for {kilometers} km is: {Math.Round(price, 1)}");
        }
    }
}
