using System;
namespace Question8;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("============= Sleepy Tom Cat =============\n");

        Console.Write("Enter number of holidays per year: ");;
        int holidays = int.Parse(Console.ReadLine());

        int normMinutes = 30000;
        int enteredMinutes = holidays * 127 + (365 - holidays) * 63;

        if (enteredMinutes > normMinutes)
        {
            Console.WriteLine("\nTom will run away");
            Console.WriteLine($"{(enteredMinutes - normMinutes) / 60} hours and {(enteredMinutes - normMinutes) % 60} minutes more for play\n");
        }
        else
        {
            Console.WriteLine("\nTom sleeps well");
            Console.WriteLine($"{(normMinutes - enteredMinutes) / 60} hours and {(normMinutes - enteredMinutes) % 60} minutes less for play\n");
        }
    }
}
