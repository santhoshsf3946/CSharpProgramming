using System;
namespace ExTwelve;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter string of number seperated by space: ");
        string numbers = Console.ReadLine();

        string[] stringArrayNumbers = numbers.Split();
        int[] numbersArray = new int[stringArrayNumbers.Length];

        for (int i = 0; i < numbersArray.Length; i++)
        {
            numbersArray[i] = int.Parse(stringArrayNumbers[i]);
        }

        Array.Sort(numbersArray);

        Console.WriteLine($"Maximum and minimum number of the said string: {numbersArray[0]}, {numbersArray[numbersArray.Length - 1]}");
    }
}
