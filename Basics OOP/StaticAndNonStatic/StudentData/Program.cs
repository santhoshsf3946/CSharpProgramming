using System;
namespace StudentData;

public class Program
{
    public static void Main(string[] args)
    {
        StudentInfo.Display();

        StudentInfo.Name = "Empty";

        StudentInfo.Display();
    }
}
