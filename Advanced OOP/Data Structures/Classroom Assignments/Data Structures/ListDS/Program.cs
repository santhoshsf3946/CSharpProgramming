using System;
namespace ListDS;

public class Program
{
    public static void Main(string[] args)
    {
        List<int> datas = new List<int>();

        datas.Add(10);
        datas.Add(20);
        // datas.Add(100);
        datas.Add(30);
        datas.Add(40);
        // datas.RemoveAt(3);
        
        datas.Remove(40);

        // foreach (var data in datas)
        // {
        //     Console.WriteLine(data);
        // }

        // for (int i = 0; i < datas.Count; i++)
        // {
        //     Console.WriteLine(datas[i]);
        // }
    }
}
