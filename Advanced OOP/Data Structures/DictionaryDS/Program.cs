using System;
namespace DictionaryDS;

public class Program
{
    public static void Main(string[] args)
    {
        Dictionary<string, int> dict = new Dictionary<string, int>(0);

        dict.Add("One", 1);
        dict.Add("Two", 2);
        dict.Add("Three", 3);
        dict.Add("Four", 4);
        dict.Add("Five", 5);
        dict.Add("Six", 6);
        dict.Add("Seven", 7);
        dict.Add("Eight", 8);
        dict.Add("Nine", 9);
        dict.Add("Ten", 10);
        dict.Add("Ten", 1010);
        dict["Five"] = 55;
        dict.Remove("Five");

        Console.WriteLine("========= Foreach Loop ========= ");
        foreach (KeyValuePair<string, int> item in dict)
        {
            Console.WriteLine($"Key: {item.Key}  Value: {item.Value}");
        }
    }
}
