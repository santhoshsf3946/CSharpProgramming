using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialClasses
{
    public partial class StudentDetails
    {
        public void GetMarks(int physics, int chemistry, int maths)
        {
            Physics = physics;
            Chemistry = chemistry;
            Maths = maths;
        }

        public void Calculate()
        {
            Total = Physics + Chemistry + Maths;
            Average = Total / 3.0;
        }

        public void ShowMark()
        {
            Console.WriteLine($"\n  Physics: {Physics}\n  Chemistry: {Chemistry}\n  Maths: {Maths}\n  Average: {Average}");
        }
    }
}