using System;
namespace ExSix;

public class Program
{
    public static void Main(string[] args)
    {
        int i = 1, j = 1, count = 0;

        Console.WriteLine("\nOdd numbers list");
        Console.WriteLine("----------------");

        while (i <= 100)
        {
            if (i % 2 != 0)
            {
                Console.Write(i);
                if (i != 99)
                {
                    Console.Write(", ");
                }
            }
            i++;
        }

        i = 1;

        Console.WriteLine("\n\nEven numbers list");
        Console.WriteLine("----------------");

        while (i <= 100)
        {
            if (i % 2 == 0)
            {
                Console.Write(i);
                if (i != 100)
                {
                    Console.Write(", ");
                }
            }
            i++;
        }
        
        i = 1;

        Console.WriteLine("\n\nPrime numbers list");
        Console.WriteLine("----------------");

        while (i < 100)
        {
            while (j <= i)
            {
                if (i % j == 0)
                {
                    count++;
                }
                j++;
            }
            if (count == 2)
            {
                Console.Write(i);
                if (i != 97)
                {
                    Console.Write(", ");
                }
            }
            count = 0;
            j = 1;
            i++;
        }

        Console.WriteLine("\n");
    }
}
