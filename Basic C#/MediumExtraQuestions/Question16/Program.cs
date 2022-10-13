using System;
namespace Question16;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("================= Back to the Past =================\n");

        Console.Write("Enter the Inherited Money: ");
        double inheritedMoney = double.Parse(Console.ReadLine());

        Console.Write("Enter year, until which he has to live in the past (inclusive): ");
        int tillYear = int.Parse(Console.ReadLine());

        double spendMoney = 0;
        int age = 18;

        for (int year = 1800; year <= tillYear ; year++)
        {
            if (year % 2 == 0)
            {
                spendMoney += 12000;
            }
            else
            {
                spendMoney += (12000 + 50 * age);
            }
            age++;
        }
        if (spendMoney <= inheritedMoney)
        {
            Console.WriteLine($"\nYes! He will live a carefree life and will have {inheritedMoney - spendMoney:0.00} dollars left.\n");
        }
        else
        {
            Console.WriteLine($"\nHe will need {Math.Abs(spendMoney - inheritedMoney):0.00} dollars to survive.\n");
        }
    }
}
