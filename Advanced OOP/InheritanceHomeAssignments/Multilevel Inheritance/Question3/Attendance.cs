using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question3
{
    public class Attendance
    {
        public DateTime Date { get; set; }
        
        public int NumberOfHoursWorked { get; set; }
        
        public Attendance(DateTime date, int numberOfHoursWorked) 
        {
            Date = date;
            NumberOfHoursWorked = numberOfHoursWorked;
        }
    }
}