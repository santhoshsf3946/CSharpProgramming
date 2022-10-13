using System;
namespace AbstractClasses;

public class Program
{
    public static void Main(string[] args)
    {
        // Syncfusion object
        Syncfusion job1 = new Syncfusion();
        job1.Name = "Developer";
        job1.Salary(30);

        // TCS Object
        TCS job2 = new TCS();
        job2.Name = "Testing Engineer";
        job2.Salary(15);
    }
}
