using System;
namespace ExFour;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the date in the specified format (dd/MM/yyyy): ");
        DateTime date = new DateTime();

        date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

        Console.WriteLine($"The day of the week for {date.ToString("d/M/yyyy")} is {date.DayOfWeek}");
    }
}
