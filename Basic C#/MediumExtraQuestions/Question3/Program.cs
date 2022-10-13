using System;
namespace Question3;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("========= Tiles Calculator =========\n");

        Console.Write("Enter the length of the ground: ");
        int groundLength = int.Parse(Console.ReadLine());

        Console.Write("Enter the width of the tile: ");
        int tileWidth = int.Parse(Console.ReadLine());

        Console.Write("Enter the length of the tile: ");
        int tileLength = int.Parse(Console.ReadLine());

        Console.Write("Enter the width of the bench: ");
        int benchWidth = int.Parse(Console.ReadLine());

        Console.Write("Enter the length of the bench: ");
        int benchLength = int.Parse(Console.ReadLine());


        double totalTiles = (double) (groundLength * groundLength - benchWidth * benchLength) / (tileWidth * tileLength);
        

        Console.WriteLine("\nNumber of tiles needed to cover the ground is: " + totalTiles);
        Console.WriteLine($"Total time needed for replacing the tiles: {totalTiles * 0.2}");
    }
}
