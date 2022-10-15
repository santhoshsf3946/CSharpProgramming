using System;

namespace Question2
{
    public class ShiftDezire : Car, IBrand
    {
        public long MakingID { get; set; }
        
        public long EngineNumber { get; set; }
        
        public long ChasisNumber { get; set; }

        public string BrandName { get; set; }
        public string ModelName { get; set; }

        public ShiftDezire(long makingID, long engineNumber, long chasisNumber, string brandName, string modelName, string fuleType, int numberOfSeats, string color, int tankCapacity, int numberOfKmDriven) : base(fuleType, numberOfSeats, color, tankCapacity, numberOfKmDriven)
        {
            MakingID = makingID;
            EngineNumber = engineNumber;
            ChasisNumber = chasisNumber;
            BrandName = brandName;
            ModelName = modelName;
        }
        
        public void ShowDetails()
        {
            Console.WriteLine($"\n{BrandName} : {ModelName}");
            Console.WriteLine($"\n\tMaking ID: {MakingID}\n\tEngine Number: {EngineNumber}\n\tChasisNumber: {ChasisNumber}\n\tFule Type: {FuleType}\n\tNumber of Seats: {NumberOfSeats}\n\tColor: {Color}\n\tTank Capacity: {TankCapacity}\n\tNumber of Kilo Meters Driven: {NumberOfKmDriven}\n");
        }
    }
}
