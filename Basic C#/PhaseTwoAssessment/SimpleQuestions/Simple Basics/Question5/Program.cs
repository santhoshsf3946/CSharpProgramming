using System;
namespace Question5;

public class Program
{
    public static void Main(string[] args)
    {
        double salary, annualSalary;

        Console.WriteLine("============= Annual Income Calculator =============\n");

        Console.Write("Enter the monthly salary: ");
        salary = double.Parse(Console.ReadLine());

        annualSalary = (salary + salary * 0.2) * 12;
        annualSalary = annualSalary - annualSalary * 0.05;

        Console.WriteLine($"The annual income of the person is: {annualSalary}\n");
    }
}