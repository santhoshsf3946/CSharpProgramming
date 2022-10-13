using System;

namespace Question1
{
    public class RegisterPerson : Personalnfo, FamilyInfo, IShowData
    {
        private static int s_registrationNumber = 1000;

        public string RegistrationNumber { get; set; }
        public DateTime DateOfRegistration { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string HouseAddress { get; set; }
        public int NumberOfSiblings { get; set; }

        public RegisterPerson(string name, MaritalStatus maritalStatus, DateTime dOB, long phone, string mail, string fatherName, string motherName, string houseAddress, int numberOfSiblings) : base(name, maritalStatus, dOB, phone, mail)
        {
            RegistrationNumber = $"RID{++s_registrationNumber}";
            DateOfRegistration = DateTime.Now;
            FatherName = fatherName;
            MotherName = motherName;
            HouseAddress = houseAddress;
            NumberOfSiblings = numberOfSiblings;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"\n Registration Number: {RegistrationNumber}\n Name: {Name}\n Marital status: {MaritalStatus}\n Date of Birth: {DOB.ToShortDateString()}\n Phone: {Phone}\n Mail: {Mail}\n Father name: {FatherName}\n MotherName: {MotherName}\n House Address: {HouseAddress}\n Number Siblings: {NumberOfSiblings}\n Date of Registration: {DateOfRegistration.ToShortDateString()}\n");
        }
    }
}
