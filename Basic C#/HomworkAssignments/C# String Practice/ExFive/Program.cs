using System;
namespace ExFive;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("========== String Comparison ==========");

        Console.Write("Input the 1st string: ");
        string text1 = Console.ReadLine();

        Console.Write("Input the 2nd string: ");
        string text2 = Console.ReadLine();

        if (text1.Length == text2.Length)
        {
            if (text1 == text2)
            {
                Console.WriteLine("The length of both strings are equal and also, both strings are equal");
            }
            else
            {
                Console.WriteLine("The length of both strings are equal but both are not equal");
            }
        }
        else
        {
            Console.WriteLine("The length of both strings are not equal therefore they are not equal");
        }
    }
}
