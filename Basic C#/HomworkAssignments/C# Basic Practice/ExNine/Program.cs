using System;
namespace ExNine;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Input Speed in km/hr: ");
        double speed = double.Parse(Console.ReadLine());
        Console.Write("Input Time: ");
        int time = int.Parse(Console.ReadLine());

        double distance = speed * time * 5 / 18;

        Console.WriteLine($"Distance Travelled: {(int) distance}");
    }
}