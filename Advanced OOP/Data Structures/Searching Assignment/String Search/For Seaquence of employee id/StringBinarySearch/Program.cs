using System;
namespace StringBinarySearch;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("================ String Binary Search ================");

        string[] stringArray = new string[]{ "SF3001", "SF3002", "SF3003", "SF3004", "SF3005", "SF3006", "SF3007", "SF3008", "SF3009", "SF3010" };

        Console.Write("\nEnter syncfusion ID to search: ");
        string searchTerm = Console.ReadLine();

        int beg = 0, end = stringArray.Length - 1, mid;
        bool found = false;

        while (beg <= end)
        {
            mid = (beg + end) / 2;

            if (searchTerm.ToUpper() == stringArray[mid])
            {
                Console.WriteLine($"\nString \"{searchTerm}\" is found at the index position: {mid}\n");
                found = true;
                break;
            }
            else if (searchTerm.ToUpper().CompareTo(stringArray[mid]) < 0)
            {
                end = mid - 1;
            }
            else
            {
                beg = mid + 1;
            }
        }

        if (!found)
        {
            Console.WriteLine($"\nString \"{searchTerm}\" is not found\n");
        }
    }
}
