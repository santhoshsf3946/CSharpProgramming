using System;
namespace Question1;

public class Program
{
    public static void Main(string[] args)
    {
        Marksheet marksheet = new Marksheet(81261820, "Santhosh", "Iruthayaraj", 98493274, new DateTime(2000, 8, 21), Gender.Male, new double[6] { 90, 95, 78, 89, 45, 34 }, new double[6] { 89, 78, 67, 98, 87, 68 }, new double[6] { 90, 95, 78, 89, 45, 34 }, new double[6] { 89, 78, 67, 98, 87, 68 }, new double[6] { 90, 95, 78, 89, 45, 34 }, new double[6] { 89, 78, 67, 98, 87, 68 }, "SHGD7E374887", DateTime.Now, 95.5);
        marksheet.CalculateUG();
        marksheet.ShowUgMarkSheet();
    }
}
