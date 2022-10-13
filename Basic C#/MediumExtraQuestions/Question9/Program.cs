using System;
namespace Question9;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=============== Harvest ===============\n");

        Console.Write("Enter the Wineyard area in square meters: ");
        int wineyardArea = int.Parse(Console.ReadLine());

        Console.Write("Enter kilograms of grapes per square meter: ");
        double grapesKg = double.Parse(Console.ReadLine());

        Console.Write("Enter how many liters of wine is needed: ");
        int requiredWine = int.Parse(Console.ReadLine());

        Console.Write("Enter number of wineyard workkers: ");
        int numberOfWorkers = int.Parse(Console.ReadLine());

        double producedWine = wineyardArea * grapesKg / 2.5 * 0.4;

        if (producedWine < requiredWine)
        {
            Console.WriteLine($"\nIt will be a tough winter! More {Math.Round(requiredWine - producedWine)} liters wine needed.\n");
        }
        else
        {
            Console.WriteLine($"\nGood harvest this year! Total wine: {Math.Round(producedWine)} liters.");
            
            double wineLeft = producedWine - requiredWine;
            Console.WriteLine($"\n{Math.Round(wineLeft)} liters left -> {Math.Round(wineLeft / numberOfWorkers)} liters per person.\n");
        }
    }
}
