using System;
namespace Question2;

public class Program
{
    public static void Main(string[] args)
    {
        double vegitablePrice, fruitPrice;
        int vegitableKg, fruitKg, totalPrice;

        Console.WriteLine("=============== Earning Harvest Calculator ===============\n");

        Console.Write("Enter vegitable price: ");
        vegitablePrice = double.Parse(Console.ReadLine());

        Console.Write("Enter fruit price: ");
        fruitPrice = double.Parse(Console.ReadLine());

        Console.Write("\nEnter kilograms of vegitables: ");
        vegitableKg = int.Parse(Console.ReadLine());

        Console.Write("Enter kilograms of fruit: ");
        fruitKg = int.Parse(Console.ReadLine());


        totalPrice = (int) Math.Round((vegitablePrice * vegitableKg + fruitPrice * fruitKg) / 1.94);

        Console.WriteLine($"\nTotal earning of the harvest in Euro is: {totalPrice}\n");
    }
}
