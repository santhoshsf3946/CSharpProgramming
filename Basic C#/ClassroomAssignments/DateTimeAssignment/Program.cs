using System;
namespace DateTimeAssignment;

public class Program
{
    public static void Main(string[] args)
    {
        DateTime dateTime = new DateTime(2021, 8, 10, 10, 40, 32);

        // 1
        Console.WriteLine("Year: " + dateTime.Year);
        Console.WriteLine("Month: " + dateTime.Month);
        Console.WriteLine("Day: " + dateTime.Day);
        Console.WriteLine("Hours: " + dateTime.Hour);
        Console.WriteLine("Minutes: " + dateTime.Minute);
        Console.WriteLine("Seconds: " + dateTime.Minute);

        // 2
        string[] times = dateTime.ToString().Split(new char[] {'/', ' ', ':'});

        Console.WriteLine("\nDateTime object in straight order: ");
        foreach (string item in times)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine("\nDateTime object in reverse order: ");
        for (int i = times.Length - 1; i >= 0; i--)
        {
            Console.Write(times[i] + " ");
        }

        // 3
        Console.Write("\n\nEnter a date and time in the specified format (yyyy/MM/dd hh:mm:ss tt): ");
        DateTime dateTime1 = new DateTime();
        dateTime1 = DateTime.ParseExact(Console.ReadLine(), "yyyy/MM/dd hh:mm:ss tt", null);

        Console.WriteLine("\nYear: " + dateTime1.Year);
        Console.WriteLine("Month: " + dateTime1.Month);
        Console.WriteLine("Day: " + dateTime1.Day);
    }
}
