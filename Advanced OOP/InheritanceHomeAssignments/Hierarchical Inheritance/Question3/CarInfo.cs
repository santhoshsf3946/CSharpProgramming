using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question3
{
    public class CarInfo
    {
        public string RCBookNumber { get; set; }

        public long EngineNumber { get; set; }

        public long ChasisNumber { get; set; }

        public int Milage { get; set; }

        public CarInfo(string rCBookNumber, long engineNumber, long chasisNumber, int milage) 
        {
            RCBookNumber = rCBookNumber;
            EngineNumber = engineNumber;
            ChasisNumber = chasisNumber;
            Milage = milage;
        }        
    }
}