using System;
using AdmissionLibrary;
using System.Collections.Generic;
namespace AdmissionApplication;

public class Operations
{
    public static void MainMenu()
    {

        List<StudentDetails> studentList = new List<StudentDetails>();

        string choice = "yes";

        // Getting N number of Student Details

        while (choice == "yes")
        {
            Console.Write("\nEnter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your father's name: ");
            string fatherName = Console.ReadLine();

            Console.Write("Enter your date of birth (dd/MM/yyyy): ");
            DateTime dob = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

            Console.Write("Enter your gender: ");
            string gender = Console.ReadLine();

            Console.Write("Enter your phone number: ");
            long phone = long.Parse(Console.ReadLine());

            Console.Write("Enter your mail: ");
            string mail = Console.ReadLine();

            Console.Write("Enter your physics mark: ");
            int physics = int.Parse(Console.ReadLine());

            Console.Write("Enter your chemistry mark: ");
            int chemistry = int.Parse(Console.ReadLine());

            Console.Write("Enter your maths mark: ");
            int maths = int.Parse(Console.ReadLine());

            StudentDetails student = new StudentDetails(name, fatherName, dob, gender, phone, mail, physics, chemistry, maths);

            studentList.Add(student);

            Console.Write("Do you want to register another student: ");
            choice = Console.ReadLine().Trim().ToLower();
        }

        // Printing N number of Student Details

        foreach (StudentDetails student in studentList)
        {
            Console.WriteLine("\nstudent name is: " + student.Name);
            Console.WriteLine("student father name is: " + student.FatherName);
            Console.WriteLine("student date of birth is: " + student.DOB.ToShortDateString());
            Console.WriteLine("student gender is: " + student.Gender);
            Console.WriteLine("student phone number is: " + student.Phone);
            Console.WriteLine("student mail id is: " + student.Mail);
            Console.WriteLine("student physics mark is: " + student.Physics);
            Console.WriteLine("student chemistry mark is: " + student.Chemistry);
            Console.WriteLine("student maths mark is: " + student.Maths);
        }

        // // Getting N number of Student Details

        // while (choice == "yes")
        // {
        //     StudentDetails student = new StudentDetails();
            
        //     Console.Write("\nEnter your name: ");
        //     student.Name = Console.ReadLine();

        //     Console.Write("Enter your father's name: ");
        //     student.FatherName = Console.ReadLine();

        //     Console.Write("Enter your date of birth (dd/MM/yyyy): ");
        //     student.DOB = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

        //     Console.Write("Enter your gender: ");
        //     student.Gender = Console.ReadLine();

        //     Console.Write("Enter your phone number: ");
        //     student.Phone = long.Parse(Console.ReadLine());

        //     Console.Write("Enter your mail: ");
        //     student.Mail = Console.ReadLine();

        //     Console.Write("Enter your physics mark: ");
        //     student.Physics = int.Parse(Console.ReadLine());

        //     Console.Write("Enter your chemistry mark: ");
        //     student.Chemistry = int.Parse(Console.ReadLine());

        //     Console.Write("Enter your maths mark: ");
        //     student.Maths = int.Parse(Console.ReadLine());

        //     studentList.Add(student);

        //     Console.Write("Do you want to register another student: ");
        //     choice = Console.ReadLine().Trim().ToLower();
        // }

        // // Printing N number of Student Details

        // foreach (StudentDetails student in studentList)
        // {
        //     Console.WriteLine("\nstudent name is: " + student.Name);
        //     Console.WriteLine("student father name is: " + student.FatherName);
        //     Console.WriteLine("student date of birth is: " + student.DOB.ToShortDateString());
        //     Console.WriteLine("student gender is: " + student.Gender);
        //     Console.WriteLine("student phone number is: " + student.Phone);
        //     Console.WriteLine("student mail id is: " + student.Mail);
        //     Console.WriteLine("student physics mark is: " + student.Physics);
        //     Console.WriteLine("student chemistry mark is: " + student.Chemistry);
        //     Console.WriteLine("student maths mark is: " + student.Maths);
        // }


        // Student 1
        // Console.Write("Enter your name: ");
        // string name1 = Console.ReadLine();

        // Console.Write("Enter your father's name: ");
        // string fatherName1 = Console.ReadLine();

        // Console.Write("Enter your date of birth (dd/MM/yyyy): ");
        // DateTime dob1 = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

        // Console.Write("Enter your gender: ");
        // string gender1 = Console.ReadLine();

        // Console.Write("Enter your phone number: ");
        // long phone1 = long.Parse(Console.ReadLine());

        // Console.Write("Enter your mail: ");
        // string mail1 = Console.ReadLine();

        // Console.Write("Enter your physics mark: ");
        // int physics1 = int.Parse(Console.ReadLine());

        // Console.Write("Enter your chemistry mark: ");
        // int chemistry1 = int.Parse(Console.ReadLine());

        // Console.Write("Enter your maths mark: ");
        // int maths1 = int.Parse(Console.ReadLine());


        // Student 2
        // Console.Write("Enter your name: ");
        // string name2 = Console.ReadLine();

        // Console.Write("Enter your father's name: ");
        // string fatherName2 = Console.ReadLine();

        // Console.Write("Enter your date of birth (dd/MM/yyyy): ");
        // DateTime dob2 = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

        // Console.Write("Enter your gender: ");
        // string gender2 = Console.ReadLine();

        // Console.Write("Enter your phone number: ");
        // long phone2 = long.Parse(Console.ReadLine());

        // Console.Write("Enter your mail: ");
        // string mail2 = Console.ReadLine();

        // Console.Write("Enter your physics mark: ");
        // int physics2 = int.Parse(Console.ReadLine());

        // Console.Write("Enter your chemistry mark: ");
        // int chemistry2 = int.Parse(Console.ReadLine());

        // Console.Write("Enter your maths mark: ");
        // int maths2 = int.Parse(Console.ReadLine());


        // Student 3
        // Console.Write("Enter your name: ");
        // string name3 = Console.ReadLine();

        // Console.Write("Enter your father's name: ");
        // string fatherName3 = Console.ReadLine();

        // Console.Write("Enter your date of birth (dd/MM/yyyy): ");
        // DateTime dob3 = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

        // Console.Write("Enter your gender: ");
        // string gender3 = Console.ReadLine();

        // Console.Write("Enter your phone number: ");
        // long phone3 = long.Parse(Console.ReadLine());

        // Console.Write("Enter your mail: ");
        // string mail3 = Console.ReadLine();

        // Console.Write("Enter your physics mark: ");
        // int physics3 = int.Parse(Console.ReadLine());

        // Console.Write("Enter your chemistry mark: ");
        // int chemistry3 = int.Parse(Console.ReadLine());

        // Console.Write("Enter your maths mark: ");
        // int maths3 = int.Parse(Console.ReadLine());


        // // Student 1
        // Console.WriteLine("\nYour name is: " + name1);
        // Console.WriteLine("Your father name is: " + fatherName1);
        // Console.WriteLine("Your date of birth is: " + dob1.ToShortDateString());
        // Console.WriteLine("Your gender is: " + gender1);
        // Console.WriteLine("Your phone number is: " + phone1);
        // Console.WriteLine("Your mail id is: " + mail1);
        // Console.WriteLine("Your physics mark is: " + physics1);
        // Console.WriteLine("Your chemistry mark is: " + chemistry1);
        // Console.WriteLine("Your maths mark is: " + maths1);

        // // Student 2
        // Console.WriteLine("\nYour name is: " + name2);
        // Console.WriteLine("Your father name is: " + fatherName2);
        // Console.WriteLine("Your date of birth is: " + dob2.ToShortDateString());
        // Console.WriteLine("Your gender is: " + gender2);
        // Console.WriteLine("Your phone number is: " + phone2);
        // Console.WriteLine("Your mail id is: " + mail2);
        // Console.WriteLine("Your physics mark is: " + physics1);
        // Console.WriteLine("Your chemistry mark is: " + chemistry2);
        // Console.WriteLine("Your maths mark is: " + maths2);

        // // Student 3
        // Console.WriteLine("\nYour name is: " + name3);
        // Console.WriteLine("Your father name is: " + fatherName3);
        // Console.WriteLine("Your date of birth is: " + dob3.ToShortDateString());
        // Console.WriteLine("Your gender is: " + gender3);
        // Console.WriteLine("Your phone number is: " + phone3);
        // Console.WriteLine("Your mail id is: " + mail3);
        // Console.WriteLine("Your physics mark is: " + physics3);
        // Console.WriteLine("Your chemistry mark is: " + chemistry3);
        // Console.WriteLine("Your maths mark is: " + maths3);


        // // Student 1 Object
        // StudentDetails student1 = new StudentDetails();

        // Console.Write("\nEnter your name: ");
        // student1.Name = Console.ReadLine();

        // Console.Write("Enter your father's name: ");
        // student1.FatherName = Console.ReadLine();

        // Console.Write("Enter your date of birth (dd/MM/yyyy): ");
        // student1.DOB = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

        // Console.Write("Enter your gender: ");
        // student1.Gender = Console.ReadLine();

        // Console.Write("Enter your phone number: ");
        // student1.Phone = long.Parse(Console.ReadLine());

        // Console.Write("Enter your mail: ");
        // student1.Mail = Console.ReadLine();

        // Console.Write("Enter your physics mark: ");
        // student1.Physics = int.Parse(Console.ReadLine());

        // Console.Write("Enter your chemistry mark: ");
        // student1.Chemistry = int.Parse(Console.ReadLine());

        // Console.Write("Enter your maths mark: ");
        // student1.Maths = int.Parse(Console.ReadLine());

        // studentList.Add(student1);


        // // Student 2 Object
        // StudentDetails student2 = new StudentDetails();

        // Console.Write("\nEnter your name: ");
        // student2.Name = Console.ReadLine();

        // Console.Write("Enter your father's name: ");
        // student2.FatherName = Console.ReadLine();

        // Console.Write("Enter your date of birth (dd/MM/yyyy): ");
        // student2.DOB = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

        // Console.Write("Enter your gender: ");
        // student2.Gender = Console.ReadLine();

        // Console.Write("Enter your phone number: ");
        // student2.Phone = long.Parse(Console.ReadLine());

        // Console.Write("Enter your mail: ");
        // student2.Mail = Console.ReadLine();

        // Console.Write("Enter your physics mark: ");
        // student2.Physics = int.Parse(Console.ReadLine());

        // Console.Write("Enter your chemistry mark: ");
        // student2.Chemistry = int.Parse(Console.ReadLine());

        // Console.Write("Enter your maths mark: ");
        // student2.Maths = int.Parse(Console.ReadLine());

        // studentList.Add(student2);


        // // Student 3 Object
        // StudentDetails student3 = new StudentDetails();

        // Console.Write("\nEnter your name: ");
        // student3.Name = Console.ReadLine();

        // Console.Write("Enter your father's name: ");
        // student3.FatherName = Console.ReadLine();

        // Console.Write("Enter your date of birth (dd/MM/yyyy): ");
        // student3.DOB = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

        // Console.Write("Enter your gender: ");
        // student3.Gender = Console.ReadLine();

        // Console.Write("Enter your phone number: ");
        // student3.Phone = long.Parse(Console.ReadLine());

        // Console.Write("Enter your mail: ");
        // student3.Mail = Console.ReadLine();

        // Console.Write("Enter your physics mark: ");
        // student3.Physics = int.Parse(Console.ReadLine());

        // Console.Write("Enter your chemistry mark: ");
        // student3.Chemistry = int.Parse(Console.ReadLine());

        // Console.Write("Enter your maths mark: ");
        // student3.Maths = int.Parse(Console.ReadLine());

        // studentList.Add(student3);

        // Console.WriteLine("\nstudent1 name is: " + student1.Name);
        // Console.WriteLine("student1 father name is: " + student1.FatherName);
        // Console.WriteLine("student1 date of birth is: " + student1.DOB.ToShortDateString());
        // Console.WriteLine("student1 gender is: " + student1.Gender);
        // Console.WriteLine("student1 phone number is: " + student1.Phone);
        // Console.WriteLine("student1 mail id is: " + student1.Mail);
        // Console.WriteLine("student1 physics mark is: " + student1.Physics);
        // Console.WriteLine("student1 chemistry mark is: " + student1.Chemistry);
        // Console.WriteLine("student1 maths mark is: " + student1.Maths);

        // Console.WriteLine("\nstudent2 name is: " + student2.Name);
        // Console.WriteLine("student2 father name is: " + student2.FatherName);
        // Console.WriteLine("student2 date of birth is: " + student2.DOB.ToShortDateString());
        // Console.WriteLine("student2 gender is: " + student2.Gender);
        // Console.WriteLine("student2 phone number is: " + student2.Phone);
        // Console.WriteLine("student2 mail id is: " + student2.Mail);
        // Console.WriteLine("student2 physics mark is: " + student2.Physics);
        // Console.WriteLine("student2 chemistry mark is: " + student2.Chemistry);
        // Console.WriteLine("student2 maths mark is: " + student2.Maths);

        // Console.WriteLine("\nstudent3 name is: " + student3.Name);
        // Console.WriteLine("student3 father name is: " + student3.FatherName);
        // Console.WriteLine("student3 date of birth is: " + student2.DOB.ToShortDateString());
        // Console.WriteLine("student3 gender is: " + student3.Gender);
        // Console.WriteLine("student3 phone number is: " + student3.Phone);
        // Console.WriteLine("student3 mail id is: " + student3.Mail);
        // Console.WriteLine("student3 physics mark is: " + student3.Physics);
        // Console.WriteLine("student3 chemistry mark is: " + student3.Chemistry);
        // Console.WriteLine("student3 maths mark is: " + student3.Maths);
    }
}
