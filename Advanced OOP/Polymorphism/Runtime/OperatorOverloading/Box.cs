using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    public class Box
    {
        private double length;  // Length of a box

        private double breadth;  // Breadth of a box

        private double height;  // Height of a box

        public Box(double length1, double breadth1, double height1)
        {
            length = length1;
            breadth = breadth1;
            height = height1;
        }

        public double CalculateVolume()
        {
            return length * breadth * height;
        }

        public static Box operator + (Box box1, Box box2)
        {
            double boxLength = box1.length + box2.length;
            double boxBreadth = box1.breadth + box2.breadth;
            double boxHeight = box1.height + box2.height;

            return new Box(boxLength, boxBreadth, boxHeight);
        }
    }
}
