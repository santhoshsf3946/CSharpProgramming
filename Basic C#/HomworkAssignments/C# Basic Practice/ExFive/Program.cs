using System;
namespace ExFive;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Physics - ");
        int physics = int.Parse(Console.ReadLine());
        Console.Write("Chemistry - ");
        int chemistry = int.Parse(Console.ReadLine());
        Console.Write("Maths - ");
        int maths = int.Parse(Console.ReadLine());

        int sum = physics + chemistry + maths;
        int percentage = sum / 3;

        Console.WriteLine($"Sum = {sum}");
        Console.WriteLine($"Percentage = {percentage}");
    }
}