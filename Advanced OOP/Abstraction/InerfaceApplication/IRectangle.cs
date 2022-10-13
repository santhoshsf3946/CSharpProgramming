using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InerfaceApplication
{
    public interface IRectangle
    {
        double Length { get; set; }

        double Breadth { get; set; }

        void CalculateArea();
    }
}
