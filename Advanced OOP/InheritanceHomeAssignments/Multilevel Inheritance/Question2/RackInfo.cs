using System;

namespace Question2
{
    public class RackInfo
    {
        public int RackNumber { get; set; }
        
        public int ColumnNumber { get; set; }
        
        public RackInfo(int rackNumber, int columnNumber) 
        {
            RackNumber = rackNumber;
            ColumnNumber = columnNumber;
        }
    }
}