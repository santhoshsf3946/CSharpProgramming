using System;
namespace ExTwo;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the date in the specified format (dd/MM/yyyy hh:mm:ss tt): ");
        DateTime date = new DateTime();

        date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy hh:mm:ss tt", null);

        Console.WriteLine($"1. Complete date: {date}");
        Console.WriteLine($"2. Short date: {date.ToString("MM/dd/yyyy")}");
        Console.WriteLine($"3. {date.DayOfWeek}, {date.ToString("MMMM yyyy hh:mm:ss tt")}");
        Console.WriteLine($"4. {date}");
        Console.WriteLine($"5. {date.ToShortDateString()}");
        Console.WriteLine($"6. {date.ToLongTimeString()}");
    }
}
