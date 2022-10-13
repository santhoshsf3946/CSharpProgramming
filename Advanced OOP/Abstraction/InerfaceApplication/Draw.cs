using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InerfaceApplication
{
    public class Draw : IRectangle
    {
        public double Length { get; set; }
        public double Breadth { get; set; }

        public void CalculateArea()
        {
            Console.WriteLine($"\nArea of the rectangle is: {Length * Breadth}\n");
        }
    }
}
