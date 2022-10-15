using System;

namespace Question1
{
    public class HSCDetails : StudentInfo
    {
        public long HSCMarkSheetNumber { get; set; }

        public double Physics { get; set; }

        public double Chemistry { get; set; }

        public double Maths { get; set; }

        public double TotalMark { get; set; }

        public HSCDetails(long registerNumber, string name, string fatherName, long phone, string mail, DateTime dOB, Gender gender, string standard, string branch, int academicYear, long hSCMarkSheetNumber, double physics, double chemistry, double maths) : base(registerNumber, name, fatherName, phone, mail, dOB, gender, standard, branch, academicYear)
        {
            HSCMarkSheetNumber = hSCMarkSheetNumber;
            Physics = physics;
            Chemistry = chemistry;
            Maths = maths;
        }

        public void Calculate()
        {
            TotalMark = Physics + Chemistry + Maths;
        }

        public void ShowInfo()
        {
            Calculate();

            Console.WriteLine($"\nRegister Number: {RegisterNumber}\nRegistered Name: {Name}\nTotal Mark: {TotalMark}");
        }
    }
}