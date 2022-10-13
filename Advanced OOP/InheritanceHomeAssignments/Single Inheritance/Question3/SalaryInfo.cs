using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question3
{
    public class SalaryInfo
    {
        public double SalaryOfTheMonth { get; set; }

        public string Month { get; set; }

        public SalaryInfo(double salaryOfTheMonth, string month) 
        {
            SalaryOfTheMonth = salaryOfTheMonth;
            Month = month;
        }
    }
}
