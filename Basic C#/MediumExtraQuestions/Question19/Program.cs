using System;
namespace Question19;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("================ Logistics ================\n");

        Console.Write("Enter how many Cargo to get: ");
        int length = int.Parse(Console.ReadLine());

        int[] cargos = new int[length];

        Console.WriteLine();

        for (int i = 0; i < length; i++)
        {
            Console.Write($"Enter Cargo Ton {i + 1}: ");
            cargos[i] = int.Parse(Console.ReadLine());
        }

        int busCargo = 0, truckCargo = 0, trainCargo = 0, totalCargo = 0;

        foreach (var cargoTons in cargos)
        {
            if (cargoTons <= 3)
            {
                busCargo += cargoTons;
            }
            else if (cargoTons <= 11)
            {
                truckCargo += cargoTons;
            }
            else
            {
                trainCargo += cargoTons;
            }
            totalCargo += cargoTons;
        }

        double averagePricePerTon = (busCargo * 200 + truckCargo * 175 + trainCargo * 120) / (double) totalCargo;

        double busPercent = Math.Round((double) busCargo / totalCargo * 100, 2);
        double truckPercent = Math.Round((double) truckCargo / totalCargo * 100, 2);
        double trainPercent = Math.Round((double) trainCargo / totalCargo * 100, 2);

        Console.WriteLine("\nAverage price per ton of the cargo: {0:0.00}", averagePricePerTon);

        Console.WriteLine("\nPercentage of the cargo carried by minibus: {0:0.00} %", busPercent);
        Console.WriteLine("Percentage of the cargo carried by truck: {0:0.00} %", truckPercent);
        Console.WriteLine("Percentage of the cargo carried by train: {0:0.00} %\n", trainPercent);
    }
}
