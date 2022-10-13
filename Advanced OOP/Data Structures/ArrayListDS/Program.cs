using System;
namespace ArrayListDS;

public class Program
{
    public static void Main(string[] args)
    {
        ArrayList objects = new ArrayList();

        objects.Add("Santhosh");
        objects.Add(22);
        objects.Add(12898.32);
        objects.Add(new DateTime(2000, 9, 27));
        objects.Add(true);
        objects.Add("Dinesh");

        foreach (var data in objects)
        {
            Console.WriteLine(data);
        }

        Console.WriteLine("=======");

        objects.Remove(new DateTime(2000, 9, 27));
        objects.RemoveAt(4);
        Console.WriteLine("Index: " + objects.IndexOf(22));

        Console.WriteLine("=======");

        for (int i = 0; i < objects.Count; i++)
        {
            Console.WriteLine(objects[i]);
        }
    }
}
