using System;
namespace Question15;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("================= Samrt Lilly =================\n");

        Console.Write("Enter Lilly's age: ");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Enter the price of the washing machine: ");
        double washingMachinePrice = double.Parse(Console.ReadLine());

        Console.Write("Enter unit price of each toy: ");
        int toyPrice = int.Parse(Console.ReadLine());

        double savedMoney = 0;

        for (int i = 10; i <= age / 2 * 10; i += 10)
        {
            savedMoney += i;
        }

        savedMoney -= (int) (age / 2);

        savedMoney += Math.Round((double) age / 2, 0, MidpointRounding.ToPositiveInfinity) * toyPrice;

        if (savedMoney < washingMachinePrice)
        {
            Console.WriteLine($"\nNo! {washingMachinePrice - savedMoney:0.00} USD\n");
        }
        else
        {
            Console.WriteLine($"\nYes! {savedMoney - washingMachinePrice:0.00} USD\n");
        }
    }
}
