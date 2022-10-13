using System;
namespace Question4;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("========== Money Calculator ==========\n");

        Console.Write("Enter number of Bitcoins: ");
        int bitcoin = int.Parse(Console.ReadLine());

        Console.Write("Enter number of chinese yuans: ");
        double yuans = double.Parse(Console.ReadLine());

        Console.Write("Enter commission fee percentage: ");
        double commission = double.Parse(Console.ReadLine());


        double totalEuro = bitcoin * 1168 / 1.95 + yuans * 0.15 * 1.76 / 1.95;
        totalEuro = totalEuro - totalEuro * commission * 0.01;
        

        Console.WriteLine($"\nHe gets the exchange of: {totalEuro} EUR\n");
    }
}
