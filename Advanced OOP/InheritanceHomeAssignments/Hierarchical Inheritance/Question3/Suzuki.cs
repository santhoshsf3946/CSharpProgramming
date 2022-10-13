using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question3
{
    public class Suzuki : CarInfo
    {
        public long CarModelNumber { get; set; }

        public string CarModelName { get; set; }

        public Suzuki(string rCBookNumber, long engineNumber, long chasisNumber, int milage, long carModelNumber, string carmodelName) : base(rCBookNumber, engineNumber, chasisNumber, milage)
        {
            CarModelNumber = carModelNumber;
            CarModelName = carmodelName;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"\nSuzuki\nRC Book Number: {RCBookNumber}\nCar Model Name: {CarModelName}");
        }
    }
}
