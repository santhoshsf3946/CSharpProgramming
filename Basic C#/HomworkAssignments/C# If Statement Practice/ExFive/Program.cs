using System;
namespace ExFive;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Physics mark: ");
        double physics = double.Parse(Console.ReadLine());

        Console.Write("Enter Chemistry mark: ");
        double chemistry = double.Parse(Console.ReadLine());

        Console.Write("Enter Mathematics mark: ");
        double maths = double.Parse(Console.ReadLine());

        double totalPercentage = (physics + chemistry + maths) / 3;

        if (totalPercentage >= 75)
        {
            Console.WriteLine("The candidate is Eligible for admission");
        }
        else
        {
            Console.WriteLine("The candidate is Not Eligible for admission");
        }
    }
}
