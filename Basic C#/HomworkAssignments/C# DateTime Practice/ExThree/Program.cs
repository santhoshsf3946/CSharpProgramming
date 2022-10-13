using System;
namespace ExThree;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the date in the specified format (dd/MM/yyyy h:mm:ss tt): ");
        DateTime date = new DateTime();

        date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy h:mm:ss tt", null);

        Console.WriteLine("Year = " + date.Year);
        Console.WriteLine("Month = " + date.Month);
        Console.WriteLine("Day = " + date.Day);
        Console.WriteLine("Hour = " + date.Hour);
        Console.WriteLine("Minute = " + date.Minute);
        Console.WriteLine("Second = " + date.Second);
        Console.WriteLine("Millisecond = " + date.Millisecond);
    }
}