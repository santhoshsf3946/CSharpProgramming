using System;
namespace ExSix;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the Temperature in Centigrade: ");
        double temperature = double.Parse(Console.ReadLine());

        if (temperature < 0)
        {
            Console.WriteLine("Freezing weather");
        }
        else if (temperature < 10)
        {
            Console.WriteLine("Very Cold weather");
        }
        else if (temperature < 20)
        {
            Console.WriteLine("Cold weather");
        }
        else if (temperature < 30)
        {
            Console.WriteLine("Normal in Temperature");
        }
        else if(temperature < 40)
        {
            Console.WriteLine("Its Hot");
        }
        else
        {
            Console.WriteLine("Its Very Hot");
        }
    }
}
