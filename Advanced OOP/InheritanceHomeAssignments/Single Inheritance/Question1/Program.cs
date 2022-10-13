using System;

namespace Question1;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("\n============== Single Inheritance ==============\n");

        StudentInfo student = new StudentInfo("Santhosh", "Iruthayaraj", 9789429543, "santhosh@mail.com", new DateTime(2000, 8, 21), Gender.Male, "12th", "Biomaths", 2016);

        student.ShowInfo();

        student.UpdateInfo("Santhosh", "Iruthayaraj", 9789429543, "santhosh@mail.com", new DateTime(2000, 8, 21), Gender.Male, "12th", "Biomaths", 2018);

        student.ShowInfo();
    }
}
