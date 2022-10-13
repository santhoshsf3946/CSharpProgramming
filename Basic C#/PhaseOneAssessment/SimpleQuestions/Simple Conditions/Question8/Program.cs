using System;
namespace Question8;

public class Program
{
    public static void Main(string[] args)
    {
        double speed;
        string speedInformation;

        Console.WriteLine("================= Speed informatin =================\n");
        speed = double.Parse(Console.ReadLine());

        if (speed <= 10)
        {
            speedInformation = "Slow";
        }
        else if (speed <= 50)
        {
            speedInformation = "Average";
        }
        else if (speed <= 150)
        {
            speedInformation = "Fast";
        }
        else if (speed <= 1000)
        {
            speedInformation = "Ultra fast";
        }
        else
        {
            speedInformation = "Extremly fast";
        }

        Console.WriteLine(speedInformation + "\n");
    }
}
