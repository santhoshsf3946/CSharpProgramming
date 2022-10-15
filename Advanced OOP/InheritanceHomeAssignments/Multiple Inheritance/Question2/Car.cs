using System;

namespace Question2
{
    public class Car
    {
        public string FuleType { get; set; }
        
        public int NumberOfSeats { get; set; }
        
        public string Color { get; set; }
        
        public int TankCapacity { get; set; }
        
        public int NumberOfKmDriven { get; set; }

        public Car(string fuleType, int numberOfSeats, string color, int tankCapacity, int numberOfKmDriven) 
        {
            FuleType = fuleType;
            NumberOfSeats = numberOfSeats;
            Color = color;
            TankCapacity = tankCapacity;
            NumberOfKmDriven = numberOfKmDriven;
        }
    }
}