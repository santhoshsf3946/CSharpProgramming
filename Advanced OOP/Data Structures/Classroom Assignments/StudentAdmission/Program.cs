using System;
namespace StudentAdmission;

public class Program
{
    public static List<StudentDetails> studentsList = new List<StudentDetails>();
    public static List<DepartmentDetails> departmentList = new List<DepartmentDetails>();
    public static List<AdmissionDetails> admissionList = new List<AdmissionDetails>();

    public static void Main(string[] args)
    {
        Console.WriteLine("=============== STUDENT ADMISSION ===============");

        Files.Create();
        Files.ReadFiles();

        // Files.UpdateInfo();
        
        // SetStudentDetailsSampleData();
        // SetDepartmentDetailsSampleDate();
        // SetAdmissionDetailsSampleData();

        ShowMainMenu();
        
        Files.WriteToFiles();
    }

    public static void ShowMainMenu()
    {
        int choice;
        do
        {
            Console.WriteLine("\n  1. Student Registration \n  2. Student Login \n  3. Check Department wise seat availability \n  4. Exit");
            Console.Write("Select one of the above choices: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                {
                    StudentRegistration();
                    break;
                }
                case 2:
                {
                    Login();
                    break;
                }
                case 3:
                {
                    ShowSeatAvailability();
                    break;
                }
                case 4:
                {
                    Console.WriteLine("\nExitting...");
                    break;
                }
                default:
                {
                    Console.WriteLine("\nInvalid Input");
                    break;
                }
            }
        } while (choice != 4);
    }

    public static void StudentRegistration()
    {
        Console.Write("\nEnter Student Name: ");
        string studentName = Console.ReadLine();

        Console.Write("Enter Father Name: ");
        string fatherName = Console.ReadLine();

        Console.Write("Enter Date of birth: ");
        DateTime dob = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
        
        Console.Write("Enter Gender (Male, Female, Transgender): ");
        Gender gender = Enum.Parse<Gender>(Console.ReadLine(), true);

        Console.Write("Enter Physics Mark: ");
        int physics = int.Parse(Console.ReadLine());

        Console.Write("Enter Chemistry Mark: ");
        int chemistry = int.Parse(Console.ReadLine());

        Console.Write("Enter Maths Mark: ");
        int maths = int.Parse(Console.ReadLine());

        StudentDetails student = new StudentDetails(studentName, fatherName, dob, gender, physics, chemistry, maths);
        studentsList.Add(student);

        Console.WriteLine($"\nStudent Added Successfully and StudentID - {student.StudentID}\n");
    }

    public static void Login()
    {
        Console.Write("\nEnter your Student ID: ");
        string studentID = Console.ReadLine().Trim().ToLower();
        
        foreach (StudentDetails student in studentsList)
        {
            if (student.StudentID.ToLower() == studentID)
            {
                Console.WriteLine("\nLogin Successfull !");
                ShowSubMenu(student);
            }
        }
    }

    public static void ShowSubMenu(StudentDetails student)
    {
        char choice;
        do
        {
            Console.WriteLine("\n  a. Check Eligiblity \n  b. Show Details \n  c. Take Admission \n  d. Cancel Admission \n  e. Show Admission Details \n  f. Logout");
            Console.Write("Select one of the above choices: ");
            choice = char.Parse(Console.ReadLine().Trim().ToLower());

            switch (choice)
            {
                case 'a':
                {
                    if (student.CheckEligiblity(75.0))
                    {
                        Console.WriteLine("\nStudent is Eligible");
                    }
                    else
                    {
                        Console.WriteLine("\nStudent is not Eligible");
                    }
                    break;
                }
                case 'b':
                {
                    student.DisplayDetails();
                    break;
                }
                case 'c':
                {
                    TakeAdmission(student);
                    break;
                }
                case 'd':
                {
                    CancelAdmission(student);
                    break;
                }
                case 'e':
                {
                    ShowAdmissionDetails(student);
                    break;
                }
                case 'f':
                {

                    Console.WriteLine("\nLogged out successfull !");
                    break;
                }
                default:
                {
                    Console.WriteLine("\nInvalid Input");
                    break;
                }
            }
        } while (choice != 'f');
    }

    public static void TakeAdmission(StudentDetails student)
    {   
        Console.WriteLine();
        foreach (DepartmentDetails department in departmentList)
        {
            Console.WriteLine($"Department ID: {department.DepartmentID}    Department Name: {department.DepartmentName}    Number of seats available: {department.NumberOfSeats}");
        }

        Console.Write("Enter Department ID: ");
        string departmentID = Console.ReadLine().Trim().ToUpper();

        bool isDepartmentIDPresent = false;

        DepartmentDetails selectedDepartment = null;

        foreach (DepartmentDetails department in departmentList)
        {
            if (department.DepartmentID == departmentID)
            {
                isDepartmentIDPresent = true;
                selectedDepartment = department;
                break;
            }
        }

        if (isDepartmentIDPresent)
        {
            if (student.CheckEligiblity(75.0))
            {
                bool admissionTook = false;
                foreach (AdmissionDetails admission in admissionList)
                {
                    if (student.StudentID == admission.StudentID)
                    {
                        admissionTook = true;
                    }
                }

                if (!admissionTook)
                {
                    selectedDepartment.NumberOfSeats -= 1;
                    AdmissionDetails admission = new AdmissionDetails(student.StudentID, departmentID, DateTime.Now, AdmissionStatus.Admitted);
                    admissionList.Add(admission);
                    Console.WriteLine($"\nAdmission took successfully. Your admission ID - {admission.AdmissionID}");
                }
                else
                {
                    Console.WriteLine("You previously took an admission");
                }
            }
            else
            {
                Console.WriteLine("You are not eligible");
            }
        }
        else
        {
            Console.WriteLine("Department ID is not present");
        }
    }

    public static void CancelAdmission(StudentDetails student)
    {
        AdmissionDetails foundAdmission = null;
        foreach (AdmissionDetails admission in admissionList)
        {
            if (admission.StudentID == student.StudentID)
            {
                Console.WriteLine($"Admission ID: {admission.AdmissionID}   Department ID: {admission.DepartmentID}    Admission Date: {admission.AdmissionDate.ToString("dd/MM/yyyy")}    Admission status: {admission.AdmissionStatus}");
                foundAdmission = admission;
            }
        }

        if (foundAdmission != null)
        {
            foundAdmission.AdmissionStatus = AdmissionStatus.Cancelled;
            foreach (DepartmentDetails department in departmentList)
            {
                if (department.DepartmentID == foundAdmission.DepartmentID)
                {
                    department.NumberOfSeats += 1;
                    break;
                }
            }
            Console.WriteLine("Seat cancelled successfully");
        }
        else
        {
            Console.WriteLine("No Admission found !");
        }
    }

    public static void ShowAdmissionDetails(StudentDetails student)
    {
        bool admissionFound = false;
        foreach (AdmissionDetails admission in admissionList)
        {
            if (admission.StudentID == student.StudentID)
            {
                Console.WriteLine($"Admission ID: {admission.AdmissionID}  Department ID: {admission.DepartmentID}  Admission Date: {admission.AdmissionDate.ToString("dd/MM/yyyy")} Admission status: {admission.AdmissionStatus}");
                admissionFound = true;
            }
        }
        if (!admissionFound)
        {
            Console.WriteLine("No Admission found");
        }
    }

    public static void ShowSeatAvailability()
    {
        foreach (DepartmentDetails department in departmentList)
        {
            Console.WriteLine($"Department ID: {department.DepartmentID}    Department Name: {department.DepartmentName}    Number of seats available: {department.NumberOfSeats}");
        }
    }

    public static void SetStudentDetailsSampleData()
    {
        studentsList.Add(new StudentDetails("Ravichandran E", "Ettapparajan", new DateTime(1999, 11, 11), Gender.Male, 95, 95, 95));
        studentsList.Add(new StudentDetails("Baskaran S", "Sethurajan", new DateTime(1999, 11, 11), Gender.Male, 95, 95, 95));
    }

    public static void SetDepartmentDetailsSampleDate()
    {
        departmentList.Add(new DepartmentDetails("EEE", 29));
        departmentList.Add(new DepartmentDetails("CSE", 29));
        departmentList.Add(new DepartmentDetails("MECH", 30));
        departmentList.Add(new DepartmentDetails("ECE", 30));
    }

    public static void SetAdmissionDetailsSampleData()
    {
        admissionList.Add(new AdmissionDetails("SF3001", "DID101", new DateTime(2022, 5, 11), AdmissionStatus.Admitted));
        admissionList.Add(new AdmissionDetails("SF3002", "DID102", new DateTime(2022, 5, 12), AdmissionStatus.Admitted));
    }
}
