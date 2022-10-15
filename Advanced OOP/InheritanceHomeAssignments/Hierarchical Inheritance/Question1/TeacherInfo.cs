using System;

namespace Question1
{
    public class TeacherInfo : PersonalInfo
    {
        public string TeacherID { get; set; }

        public string Department { get; set; }

        public string SubjectTeaching { get; set; }

        public string Qualification { get; set; }

        public int YearOfExperience { get; set; }

        public DateTime DateOfJoining { get; set; }

        public TeacherInfo(string teacherID, string name, string fatherName, DateTime dOB, long phone, Gender gender, string mail, string department, string subjectTeaching, string qualification, int yearOfExperience, DateTime dateOfJoining) : base(name, fatherName, dOB, phone, gender , mail)
        {
            TeacherID = teacherID;
            Department = department;
            SubjectTeaching = subjectTeaching;
            Qualification = qualification;
            YearOfExperience = yearOfExperience;
            DateOfJoining = dateOfJoining;
        }        
    }
}
