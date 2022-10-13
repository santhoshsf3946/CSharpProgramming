using System;
namespace Question9;

public class Program
{
    public static void Main(string[] args)
    {
        string month, monthLower;
        int leaves, daysInMonth;

        Console.WriteLine("=============== Salary Calculator ===============\n");

        Console.Write("Enter the month : ");
        month = Console.ReadLine();
        monthLower = month.ToLower();

        Console.Write("Enter the leaves taken: ");
        leaves = int.Parse(Console.ReadLine());

        switch (monthLower)
        {
            case "january":
            case "march":
            case "may":
            case "july":
            case "august":
            case "october":
            case "december":
            {
                daysInMonth = 31;
                break;
            }
            case "april":
            case "june":
            case "september":
            case "november":
            {
                daysInMonth = 30;
                break;
            }
            case "february":
            {
                daysInMonth = 28;
                break;
            }
            default:
            {
                daysInMonth = -1;
                break;
            }
        }
        if (daysInMonth < 0)
            {
                Console.WriteLine("Invalid Month");
            }
            else
            {
                Console.WriteLine($"Salary for the month {month} is: {(daysInMonth - leaves) * 500}\n");
            }
    }
}