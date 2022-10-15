using System;
using MathsLib;

namespace CalculatorApp
{
    public class CircleArea : Maths
    {
        protected double radius;

        public double Radius { get{ return radius; } set { radius = value; } }
        
        internal double Area { get; set; }
        
        public double CalculateCircleArea()
        {
            Area = PI * radius * radius;
            return Area;
        }
    }
}
