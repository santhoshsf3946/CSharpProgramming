using System;

namespace Question2
{
    public class SalaryInfo
    {
       
        public double BasicSalary { get; set; }

        public int Month { get; set; }

        public SalaryInfo(double basicSalary, int month) 
        {
            BasicSalary = basicSalary;
            Month = month;
        }
    }
}