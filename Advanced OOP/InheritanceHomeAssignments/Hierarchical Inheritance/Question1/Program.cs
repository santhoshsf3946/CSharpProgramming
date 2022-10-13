using System;
namespace Question1;

public class Program
{
    public static void Main(string[] args)
    {
        PrincipalInfo principalInfo = new PrincipalInfo("PID1001", "Baskaran", "Sethurajan", new DateTime(1985, 9, 12), 8478742, Gender.Male, "baskaran@mail.com", "P.Hd", 11, new DateTime(2011, 7, 16));
        TeacherInfo teacherInfo = new TeacherInfo("TID1001", "Ravichandran", "Ettapparajan", new DateTime(1985, 6, 16), 9834729, Gender.Male, "ravi@mail.com", "EEE", "CS", "PHd", 10, new DateTime(2012, 8, 22));
        StudentInfo studentInfo = new StudentInfo("SID1001", "Santhosh", "Iruthayaraj", new DateTime(2022, 8, 21), 8792349432, Gender.Male, "santhosh@mail.com", "B.Tech", "IT", 8);

        Console.WriteLine($"Principal Name: {principalInfo.Name} Pricipal ID: {principalInfo.PricipalID}");
        Console.WriteLine($"Teacher Name: {teacherInfo.Name} Teacher ID: {teacherInfo.TeacherID}");
        Console.WriteLine($"Student Name: {studentInfo.Name} Student ID: {studentInfo.StudentID}");
    }
}
