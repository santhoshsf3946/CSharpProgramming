using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleInheritance
{
    public interface IMarkDetails
    {
        // No fields
        int Physics { get; set; }  // Property declaration only allowed

        int Chemistry { get; set; }

        int Maths { get; set; }

        int Total { get; set; }

        double Average { get; set; }


        // No constructor and no objects

        void GetMarks(int physics, int chemistry, int maths);

        void Calculate();  // Method declaration only allowed
    }
}
