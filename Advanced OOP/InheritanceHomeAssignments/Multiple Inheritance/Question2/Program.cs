using System;
namespace Question2;

public class Program
{
    public static void Main(string[] args)
    {
        // ShiftDezire object
        ShiftDezire shiftDezire = new ShiftDezire(482742849884, 4832464, 7788, "BMW", "B36", "Gas", 4, "White", 30, 10000);

        shiftDezire.ShowDetails();

        // Eco object
        Eco eco = new Eco(85475857385, 847848, 3874, "Tesla", "R1", "Electric", 6, "Gray", 40, 12000);
        eco.ShowDetails();
    }
}
