using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employment
{
    public enum Gender { Default, Male, Female, Others };

    public class PersonalDetails
    {
        public static int s_aadhaarID = 1000;

        public string AadhaarID { get; set; }

        public string Name { get; set; }

        public string FatherName { get; set; }

        public Gender Gender { get; set; }

        public long Phone { get; set; }

        public PersonalDetails(string name, string fatherName, Gender gender, long phone)
        {
            Name = name;
            FatherName = fatherName;
            Gender = gender;
            Phone = phone;
            s_aadhaarID++;
            AadhaarID = $"AID{s_aadhaarID}";
        }

        public void ShowDetails()
        {
            Console.WriteLine($"\n  Aadhar ID: {AadhaarID}\n  Name: {Name}\n  Father Name: {FatherName}\n  Gender: {Gender}\n  Phone: {Phone}\n");
        }
    }
}