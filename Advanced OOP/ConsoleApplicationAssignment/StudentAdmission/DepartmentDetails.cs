using System;

namespace StudentAdmission
{
    public class DepartmentDetails
    {
        private static int s_departmentID = 100;
        public string DepartmentID { get; set; }

        public string DepartmentName { get; set; }

        public int NumberOfSeats { get; set; }

        public DepartmentDetails(string departmentName, int numberOfSeats)
        {
            s_departmentID++;
            DepartmentID = $"DID{s_departmentID}";
            DepartmentName = departmentName;
            NumberOfSeats = numberOfSeats;
        }

        public DepartmentDetails(string data)
        {
            string[] valuess = data.Split(',');
            s_departmentID = int.Parse(valuess[0].Remove(0, 3));
            DepartmentID = valuess[0];
            DepartmentName = valuess[1];
            NumberOfSeats = int.Parse(valuess[2]);
        }
    }
}
