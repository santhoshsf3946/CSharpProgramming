using System;

namespace StudentAdmission
{
    public enum AdmissionStatus {Default, Admitted, Cancelled}
    public class AdmissionDetails
    {
        private int s_admissionID = 1000;

        public string AdmissionID { get; set; }

        public string StudentID { get; set; }

        public string DepartmentID { get; set; }

        public DateTime AdmissionDate { get; set; }

        public AdmissionStatus AdmissionStatus { get; set; }

        public AdmissionDetails(string studentID, string departmentID, DateTime admissionDate, AdmissionStatus admissionStatus)
        {
            s_admissionID++;
            AdmissionID = $"AID{s_admissionID}";
            StudentID = studentID;
            DepartmentID = departmentID;
            AdmissionDate = admissionDate;
            AdmissionStatus = admissionStatus;
        }

        public AdmissionDetails(string data)
        {
            string[] values = data.Split(',');
            s_admissionID = int.Parse(values[0].Remove(0, 3));
            AdmissionID = $"AID{values[0]}";
            StudentID = values[1];
            DepartmentID = values[2];
            AdmissionDate = DateTime.Parse(values[3]);
            AdmissionStatus = Enum.Parse<AdmissionStatus>(values[4]);
        }
    }
}
