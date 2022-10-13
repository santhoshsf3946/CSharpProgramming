using System;

namespace Question1
{
    public enum MaritalStatus { Default, Married, Single }
    public class Personalnfo : IShowData
    {
        public string Name { get; set; }

        public long Phone { get; set; }

        public string Mail { get; set; }

        public DateTime DOB { get; set; }

        public MaritalStatus MaritalStatus { get; set; }

        public Personalnfo(string name, MaritalStatus maritalStatus, DateTime dOB, long phone, string mail) 
        {
            Name = name;
            Phone = phone;
            Mail = mail;
            DOB = dOB;
            MaritalStatus = maritalStatus;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Name: {Name} Marital status: {MaritalStatus} Date of Birth: {DOB} Phone: {Phone} Mail: {Mail}");
        }
    }
}
