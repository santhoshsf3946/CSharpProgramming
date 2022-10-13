using System;
namespace Question1;

public class Program
{
    public static void Main(string[] args)
    {
        double workingPlaceLength = 70, workingPlaceWidth = 120, hallWayWidth = 100, trainingLabLength, trainingLabWidth;
        int totalWorkingPlacesLength = 0, totalWorkingPlacesWidth = 0, podiumSpace = 2, entranceDoorSpace = 1, totalWorkingPlaces;
        

        Console.WriteLine("\n=========== Training Halway Working Place Calculator ===========\n");

        Console.Write("Enter the length of the training lab: ");
        trainingLabLength = double.Parse(Console.ReadLine()) * 100;

        Console.Write("Enter the width of the training lab: ");
        trainingLabWidth = double.Parse(Console.ReadLine()) * 100;


        totalWorkingPlacesWidth = (int) (trainingLabLength / workingPlaceWidth);
        totalWorkingPlacesLength = (int) ((trainingLabWidth - hallWayWidth) / workingPlaceLength);

        totalWorkingPlaces = totalWorkingPlacesWidth * totalWorkingPlacesLength - podiumSpace - entranceDoorSpace;


        Console.WriteLine($"\nThe number of working places in the training lab: {totalWorkingPlaces}\n");
    }
}
