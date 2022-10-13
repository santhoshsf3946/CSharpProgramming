using System;
namespace Question11;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=================== Cinema ===================\n");

        Console.Write("Enter type of screening: ");
        string screeningType = Console.ReadLine().Trim().ToLower();

        double price = 0;

        switch (screeningType)
        {
            case "premiere":
            {
                price = 12;
                break;
            }
            case "normal":
            {
                price = 7.5;
                break;
            }
            case "discount":
            {
                price = 5;
                break;
            }
            default:
            {
                break;
            }
        }

        if (price != 0)
        {
            Console.Write("Enter number of rows: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Enter number of columns: ");
            int columns = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nThe total income of the full hall: {Math.Round(rows * columns * price, 2):0.00}\n");
        }
        else
        {
            Console.WriteLine("\nInvalid Screening Type !\n");
        }
    }
}
