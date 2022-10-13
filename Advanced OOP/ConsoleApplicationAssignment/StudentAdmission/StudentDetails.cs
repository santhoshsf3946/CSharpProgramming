using System;

namespace StudentAdmission
{
    public enum Gender { Default, Male, Female, Transgender }
    public class StudentDetails
    {
        private static int s_studentID = 3000;

        public string StudentID { get; set; }

        public string StudentName { get; set; }

        public string FatherName { get; set; }

        public DateTime DOB { get; set; }

        public Gender Gender { get; set; }

        public double Physics { get; set; }

        public double Chemistry { get; set; }

        public double Maths { get; set; }

        public StudentDetails (string studentName, string fatherName, DateTime dob, Gender gender,double physics, double chemistry, double maths)
        {
            s_studentID++;
            StudentID = $"SF{s_studentID}";
            StudentName = studentName;
            FatherName = fatherName;
            DOB = dob;
            Gender = gender;
            Physics = physics;
            Chemistry = chemistry;
            Maths = maths;
        }

        public StudentDetails (string data)
        {
            string[] values = data.Split(',');
            s_studentID = int.Parse(values[0].Remove(0, 2));
            StudentID = values[0];
            StudentName = values[1];
            FatherName = values[2];
            DOB = DateTime.Parse(values[3]);
            Gender = Enum.Parse<Gender>(values[4]);
            Physics = double.Parse(values[5]);
            Chemistry = double.Parse(values[6]);
            Maths = double.Parse(values[7]);
        }

        public bool CheckEligiblity (double cutOff)
        {
            return (Physics + Chemistry + Maths) / 3 >= cutOff;
        }

        public void DisplayDetails ()
        {
            Console.WriteLine("\nStudent Details\n---------------");
            Console.WriteLine($" Student Name: {StudentName}\n Father Name: {FatherName}\n Date of Birth: {DOB.ToString("dd/MM/yyyy")}\n Gender: {Gender}");
            Console.WriteLine($" Physics Mark: {Physics}\n Chemistry Mark: {Chemistry}\n Maths Mark: {Maths}");
        }
    }
}
