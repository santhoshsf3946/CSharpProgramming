using System;
namespace  Question4;

public class Program
{
    public static void Main(string[] args)
    {
        string text, resultText = "";
        char[] charArray;
        bool found = false;

        Console.WriteLine("========== Remove Duplicate Characters ==========\n");

        Console.Write("Enter the string: ");
        text = Console.ReadLine();

        charArray = text.ToCharArray();


        foreach (char character in text)
        {
            foreach (char item in resultText)
            {
                if (item == character)
                {
                    found = true;
                }
            }
            if (!found)
            {
                resultText += character;
            }
            found = false;
        }

        Console.WriteLine("Result string is: " + resultText);
    }
}
