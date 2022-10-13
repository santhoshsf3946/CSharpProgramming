using System;

namespace Question1
{
    public class PrincipalInfo : Personalnfo
    {
        public string PricipalID { get; set; }

        public string Qualification { get; set; }

        public int YearOfExperience { get; set; }

        public DateTime DateOfJoining { get; set; }

        public PrincipalInfo(string pricipalID, string name, string fatherName, DateTime dOB, long phone, Gender gender, string mail, string qualification, int yearOfExperience, DateTime dateOfJoining) : base(name, fatherName, dOB, phone, gender , mail)
        {
            PricipalID = pricipalID;
            Qualification = qualification;
            YearOfExperience = yearOfExperience;
            DateOfJoining = dateOfJoining;
        }
    }
}