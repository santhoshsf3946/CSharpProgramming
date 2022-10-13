using System;
namespace Question13;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("================= Point in the Figure =================\n");

        Console.Write("Enter side of the square: ");
        int h = int.Parse(Console.ReadLine());

        Console.Write("Enter the X value of the point: ");
        int x = int.Parse(Console.ReadLine());

        Console.Write("Enter the Y value of the point: ");
        int y = int.Parse(Console.ReadLine());

        if(0 <= x && x <= h * 3 && y == 0 || x == 0 && 0 <= y && y <= h || 0 <= x && x <= h && y == h || x == 2 && h <= x && x <= h * 4 || h <= x && x <= h * 2 && y == h * 4 || x == h * 2 && h <= y && y <= h * 4 || h * 2 <= x && x <= h * 3 && y == h || x == h * 3 && 0 <= y && y <= h)
        {
            Console.WriteLine("\nBorder\n");
        }
        else if (0 < x && x < h * 3 && 0 < y && y < h || h < x && x < h * 2 && 0 < y && y < h * 4)
        {
            Console.WriteLine("\nInside\n");
        }
        else
        {
            Console.WriteLine("\nOutside\n");
        }
    }
}
