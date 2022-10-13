using System;
namespace ExEight;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=============== Substring ===============");

        Console.Write("Input the string: ");
        string text = Console.ReadLine();

        Console.Write("Input the position to start extraction: ");
        int startIndex = int.Parse(Console.ReadLine());

        Console.Write("Input the length of substring: ");
        int length = int.Parse(Console.ReadLine());

        Console.Write("The substring retrived from the string: ");
        for (int i = startIndex; i < startIndex + length; i++)
        {
            Console.Write(text[i]);
        }
    }
}
