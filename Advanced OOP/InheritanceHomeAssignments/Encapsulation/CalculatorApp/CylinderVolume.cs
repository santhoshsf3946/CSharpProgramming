using System;

namespace CalculatorApp
{
    public class CylinderVolume : CircleArea
    {
        private double _height;

        public double Height { get{ return _height; } set { _height = value; } }
        
        internal double Volume { get; set; }
        
        public double CalculateVolume ()
        {
            Volume = CalculateCircleArea() * Height;
            return Volume;
        }
    }
}