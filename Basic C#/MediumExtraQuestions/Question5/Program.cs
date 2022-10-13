using System;
namespace Question5;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=========== Daily Earning Calculator ===========\n");

        Console.Write("Enter work days per month: ");
        int workDays = int.Parse(Console.ReadLine());

        Console.Write("Enter the daily earnings in USD: ");
        double dailyEarningInUsd = double.Parse(Console.ReadLine());

        Console.Write("Exchange rate of USD to EUR ( 1 dollar = X euro ): ");
        double exchangeRate = double.Parse(Console.ReadLine());



        double dailyEarningInEUR = workDays * dailyEarningInUsd;
        double bonus = dailyEarningInEUR * 2.5;
        dailyEarningInEUR = dailyEarningInEUR * 12 + bonus;
        dailyEarningInEUR = dailyEarningInEUR - dailyEarningInEUR * 0.25;
        dailyEarningInEUR = dailyEarningInEUR / 365;
        dailyEarningInEUR = Math.Round(dailyEarningInEUR * exchangeRate, 2);


        Console.WriteLine(dailyEarningInEUR);
    }
}
