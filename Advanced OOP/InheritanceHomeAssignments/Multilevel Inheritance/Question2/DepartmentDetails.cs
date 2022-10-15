using System;

namespace Question2
{
    public class DepartmentDetails : RackInfo
    {
        public string DepartmentName { get; set; }
        
        public string Degree { get; set; }
        
        public DepartmentDetails(string departmentName, string degree, int rackNumber, int columnNumber) : base(rackNumber, columnNumber)
        {
            DepartmentName = departmentName;
            Degree = degree;
        }
    }
}
