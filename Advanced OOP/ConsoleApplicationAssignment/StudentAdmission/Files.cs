using System;
using System.IO;


namespace StudentAdmission
{
    public static class Files
    {
        
        public static void Create()
        {
            if (!Directory.Exists("College"))
            {
                Console.WriteLine("\nCreating College folder...\n");
                Directory.CreateDirectory("College");
            }

            if (!File.Exists("College/StudentDetails.csv"))
            {
                Console.WriteLine("\nCreating StudentDetails.csv file\n");
                File.Create("College/StudentDetails.csv");
            }

            if (!File.Exists("College/DepartmentDetails.csv"))
            {
                Console.WriteLine("\nCreating DepartmentDetails.csv file\n");
                File.Create("College/DepartmentDetails.csv");
            }

            if (!File.Exists("College/AdmissionDetails.csv"))
            {
                Console.WriteLine("\nCreating AdmissionDetails.csv file\n");
                File.Create("College/AdmissionDetails.csv");
            }
        }

        public static void ReadFiles()
        {
            string[] students = File.ReadAllLines("College/StudentDetails.csv");

            foreach (string data in students)
            {
                Program.studentsList.Add(new StudentDetails(data));
            }

            string[] departments = File.ReadAllLines("College/DepartmentDetails.csv");

            foreach (string data in departments)
            {
                Program.departmentList.Add(new DepartmentDetails(data));
            }

            string[] admissions = File.ReadAllLines("College/AdmissionDetails.csv");

            foreach (string data in admissions)
            {
                Program.admissionList.Add(new AdmissionDetails(data));
            }
        }

        public static void WriteToFiles()
        {
            string[] studentDetailsList = new string[Program.studentsList.Count];

            for (int i = 0; i < Program.studentsList.Count; i++)
            {
                studentDetailsList[i] = Program.studentsList[i].StudentID +  "," + Program.studentsList[i].StudentName +  "," + Program.studentsList[i].FatherName +  "," +  Program.studentsList[i].DOB.ToShortDateString() +  "," + Program.studentsList[i].Gender +  "," + Program.studentsList[i].Physics +  "," + Program.studentsList[i].Chemistry +  "," + Program.studentsList[i].Maths;
            }

            File.WriteAllLines("College/StudentDetails.csv", studentDetailsList);

            
            string[] departmentDetailsList = new string[Program.departmentList.Count];

            for (int i = 0; i < Program.departmentList.Count; i++)
            {
                departmentDetailsList[i] = Program.departmentList[i].DepartmentID + "," + Program.departmentList[i].DepartmentName + "," + Program.departmentList[i].NumberOfSeats;
            }

            File.WriteAllLines("College/DepartmentDetails.csv", departmentDetailsList);

            
            string[] admisiionDetailsList = new string[Program.admissionList.Count];

            for (int i = 0; i < Program.admissionList.Count; i++)
            {
                admisiionDetailsList[i] = Program.admissionList[i].DepartmentID + "," + Program.admissionList[i].StudentID + "," + Program.admissionList[i].DepartmentID + "," + Program.admissionList[i].AdmissionDate.ToShortDateString() + "," + Program.admissionList[i].AdmissionStatus;
            }

            File.WriteAllLines("College/AdmissionDetails.csv", admisiionDetailsList);
        }

        public static void UpdateInfo()
        {
            List<StudentDetails> newStudentsList = new List<StudentDetails>();
            StudentDetails selectedStudent = null;

            string[] students = File.ReadAllLines("College/StudentDetails.csv");

            Console.WriteLine("\nStudent Details\n");

            foreach (string data in students)
            {
                StudentDetails studentDetails = new StudentDetails(data);
                newStudentsList.Add(studentDetails);
                Console.WriteLine("\tName\t\tFather Name\tDate of Birth\tGender\tPhysics Mark\tChemistry Mark\tMaths Mark");
                Console.WriteLine("\t----\t\t-----------\t-------------\t------\t------------\t--------------\t----------");
                Console.WriteLine($"\t{studentDetails.StudentName}\t{studentDetails.FatherName}\t{studentDetails.DOB.ToShortDateString()}\t{studentDetails.Gender}\t{studentDetails.Physics}\t\t{studentDetails.Chemistry}\t\t{studentDetails.Maths}\n");
            }

            Console.Write("\nEnter the Student ID to select the student: ");
            string studentID = Console.ReadLine().Trim().ToUpper();

            foreach (StudentDetails student in newStudentsList)
            {
                if (studentID == student.StudentID)
                {
                    selectedStudent = student;
                }
            }

            if (selectedStudent != null)
            {
                Console.Write("\nDo you want to change\n\t1. Name\n\t2. Father Name\nEnter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                string name = "";
                if (choice == 1)
                {
                    Console.Write("Enter new Name: ");
                    name = Console.ReadLine();

                    selectedStudent.StudentName = name;
                    Console.WriteLine($"\nStudent name changed to name: {selectedStudent.StudentName}");
                }
                else if (choice == 2)
                {
                    Console.Write("Enter new Father Name: ");
                    name = Console.ReadLine();

                    selectedStudent.FatherName = name;
                    Console.WriteLine($"\nStudent name changed to name: {selectedStudent.FatherName}");
                }
                else
                {
                    Console.WriteLine("\nInavlid Choice\n");
                }
            }
            else
            {
                Console.WriteLine("\nStudent ID not found");
            }

            string[] studentDetailsList = new string[newStudentsList.Count];

            for (int i = 0; i < newStudentsList.Count; i++)
            {
                studentDetailsList[i] = newStudentsList[i].StudentID +  "," + newStudentsList[i].StudentName +  "," + newStudentsList[i].FatherName +  "," +  newStudentsList[i].DOB.ToShortDateString() +  "," + newStudentsList[i].Gender +  "," + newStudentsList[i].Physics +  "," + newStudentsList[i].Chemistry +  "," + newStudentsList[i].Maths;
            }

            File.WriteAllLines("College/StudentDetails.csv", studentDetailsList);
        }
    }
}
