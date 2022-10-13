using System;
namespace Question1;

public class Program
{
    public static void Main(string[] args)
    {
        double salary, hra, da, annualGrossSalary, takeHomeSalary;

        Console.WriteLine("=========== Salary Calculator ===========\n");

        Console.Write("Enter the salary : ");
        salary = int.Parse(Console.ReadLine());

        if (salary <= 10000)
        {
            hra = 0.2;
            da = 0.8;
        }
        else if (salary <= 20000)
        {
            hra = 0.25;
            da = 0.9;
        }
        else
        {
            hra = 0.3;
            da = 0.95;
        }

        takeHomeSalary = salary + (salary * hra + salary * da);

        annualGrossSalary = takeHomeSalary * 12;
        annualGrossSalary = annualGrossSalary - annualGrossSalary * 0.07;

        Console.WriteLine("Annual Gross Salary is: " + annualGrossSalary);
        Console.WriteLine("Take Home Salary is: " + takeHomeSalary);
    }
}
