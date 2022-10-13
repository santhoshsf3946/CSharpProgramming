using System;
namespace ExNine;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a month: ");
        string month = (Console.ReadLine()).ToLower();

        if (month == "december" || month == "january" || month == "february")
        {
            Console.WriteLine("It's Winter");
        }
        else if (month == "march" || month == "april" || month == "may")
        {
            Console.WriteLine("It's Spring");
        }
        else if (month == "june" || month == "july" || month == "august")
        {
            Console.WriteLine("It's Summer");
        }
        else if (month == "september" || month == "october" || month == "november")
        {
            Console.WriteLine("It's Rainfall");
        }
        else
        {
            Console.WriteLine("Invalid Month");
        }
    }
}
