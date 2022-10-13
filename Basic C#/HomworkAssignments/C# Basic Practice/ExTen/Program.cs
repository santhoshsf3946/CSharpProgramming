using System;
namespace ExTen;

public class Program
{
    public static void Main(string[] args)
    {
        int value1 = 15, value2 = 20;

        Console.WriteLine(value1 > value2);
        Console.WriteLine(value1 < value2);
        Console.WriteLine(value1 >= value2);
        Console.WriteLine(value1 == value2);
        Console.WriteLine(value1 != value2);
        Console.WriteLine(value1 <= value2);
        Console.WriteLine(value1 >= 10 && value2 >= 10);
        Console.WriteLine(value1 >= 10 || value2 >= 30);
        Console.WriteLine(!(value1 > 20));
        string value = value1 == 15 ? "true" : "false";
        Console.WriteLine(value);
        Console.WriteLine(value1++);
        Console.WriteLine(value1--);
    }
}