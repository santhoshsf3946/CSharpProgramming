using System;
using System.Collections.Generic;
namespace VaccinationDrive;

public class Program
{
    public static List<Beneficiary>  beneficiaryList = new List<Beneficiary>();
    public static List<Vaccine> vaccineList = new List<Vaccine>();
    public static List<Vaccination> vaccinationList = new List<Vaccination>();

    static Beneficiary currentBeneficiary = null;

    public static void Main(string[] args)
    {
        Console.WriteLine("=============== Vaccination Drive ===============");

        Files.Create();

        Files.ReadFiles();

        // SetBeneficiarySampleData();
        // SetVaccineSampleData();
        // SetVaccinationSampleData();

        MainMenu();

        Files.WriteToFiles();
    }

    public static void MainMenu()
    {
        int choice;
        do
        {
            Console.WriteLine("\n\t1. Beneficiary Registration \n\t2. Login \n\t3. Get Vaccine Info \n\t4. Exit");
            Console.Write("Please select one of the above choices: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                {
                    BeneficiaryRegistration();
                    break;
                }
                case 2:
                {
                    Login();
                    break;
                }
                case 3:
                {
                    ShowVaccineInfo();
                    break;
                }
                case 4:
                {
                    Console.WriteLine($"\nThankyou for visiting our vaccination drive ! \n\n\" Wear a mask to protect yourself and others {(char) 1} \"\n");
                    break;
                }
                default:
                {
                    Console.WriteLine("Invalid Input");
                    break;
                }
            }
        } while (choice != 4);
    }

    public static void ShowVaccineInfo()
    {
        Console.WriteLine();
        foreach (var vaccine in vaccineList)
        {
            vaccine.ShowVaccineDetails();
        }
    }

    public static void ShowSubMenu()
    {
        int choice;
        do
        {
            Console.WriteLine("\n\t1. Show My Details \n\t2. Take Vaccination \n\t3. My Vaccination History \n\t4. Next Due Date \n\t5. Logout");
            Console.Write("Please select one of the above choices: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                {
                    currentBeneficiary.ShowMyDetails();
                    break;
                }
                case 2:
                {
                    TakeVaccination();
                    break;
                }
                case 3:
                {
                    VaccinationHistory();
                    break;
                }
                case 4:
                {
                    NextDueDate();
                    break;
                }
                case 5:
                {
                    Console.WriteLine("\nLogged out successfully");
                    break;
                }
                default:
                {
                    Console.WriteLine("\nInvalid Input");
                    break;
                }
            }
        } while (choice != 5);
    }

    public static void Login()
    {
        Console.Write("\nEnter your Register number: ");
        string registerNumber = Console.ReadLine().Trim().ToUpper();

        foreach (var beneficiary in beneficiaryList)
        {
            if (registerNumber == beneficiary.RegisterNumber)
            {
                currentBeneficiary = beneficiary;
                Console.WriteLine($"\nLogin Successfull !\tWelcome {currentBeneficiary.Name}");
                ShowSubMenu();
            }
        }

        if (currentBeneficiary == null)
        {
            Console.WriteLine("\nInvalid Register Number");
        }
    }


    public static void TakeVaccination()
    {
        Vaccination previousVaccination = null;
        Vaccine previousVaccine = null;
        if (currentBeneficiary.Age > 14)
        {
            bool doseExeeded = false;
            foreach (var vaccination in vaccinationList)
            {
                if (currentBeneficiary.RegisterNumber == vaccination.RegisterNumber)
                {
                    previousVaccination = vaccination;
                    if (vaccination.DoseNumber >= 3)
                    {
                        doseExeeded = true;
                    }
                }
            }

            if (!doseExeeded)
            {
                Console.WriteLine("\n  Available Vaccines\n  ------------------");
                foreach (var vaccine in vaccineList)
                {
                    vaccine.ShowVaccineDetails();
                }

                Console.Write("\nEnter the Vaccine ID to select the vaccine: ");
                string vaccineID = Console.ReadLine().Trim().ToUpper();

                if (previousVaccination != null)
                {
                    foreach (var vaccine in vaccineList)
                    {
                        if (previousVaccination.VaccineID == vaccine.VaccineID)
                        {
                            previousVaccine = vaccine;
                        }
                    }
                    if (previousVaccination.VaccineID == vaccineID)
                    {
                        if (previousVaccination.VaccinatedDate.AddDays(30) < DateTime.Now)
                        {
                            if (previousVaccine.NoOfDoseAvailable > 0)
                            {
                                vaccinationList.Add(new Vaccination(currentBeneficiary.RegisterNumber, vaccineID, previousVaccination.DoseNumber + 1, DateTime.Now));
                                previousVaccine.NoOfDoseAvailable--;
                                Console.WriteLine("\nYou are vaccinated successfully !");
                            }
                            else
                            {
                                Console.WriteLine($"\n{previousVaccine.VaccineName} not available now. Please come back later");
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nYou are not completed 30 days after the previous vaccination");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"\nYou have selected different vaccine. You can vaccine with ( {previousVaccine.VaccineName} / {previousVaccine.VaccineName} )");
                    }
                }
                else
                {
                    bool vaccineFound = false;
                    foreach (var vaccine in vaccineList)
                    {
                        if (vaccineID == vaccine.VaccineID)
                        {
                            vaccineFound = true;
                            vaccine.NoOfDoseAvailable--;
                        }
                    }
                    if (vaccineFound)
                    {
                        vaccinationList.Add(new Vaccination(currentBeneficiary.RegisterNumber, vaccineID, 1, DateTime.Now));
                        Console.WriteLine("\nYou are vaccinated successfully !");
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid Vaccine ID");
                    }
                }               
            }
            else
            {
                Console.WriteLine("\nAll the three Vaccination course are completed you cannot be vaccinated now");
            }
        }
        else
        {
            Console.WriteLine("\nYou are under 14. Not eligible for taking the vaccination");
        }
    }

    public static void VaccinationHistory()
    {
        bool found = false;
        Console.WriteLine("\n  Vaccination History\n  -------------------");
        foreach (var vaccination in vaccinationList)
        {
            if (vaccination.RegisterNumber == currentBeneficiary.RegisterNumber)
            {
                found = true;
                vaccination.ShowVaccinationDetails();
            }
        }
        if (!found)
        {
            Console.WriteLine("\n  You don't have any vaccination history");
        }
    }

    public static void NextDueDate()
    {
        Vaccination lastVaccination = null;
        foreach (var vaccination in vaccinationList)
        {
            if (currentBeneficiary.RegisterNumber == vaccination.RegisterNumber)
            {
                lastVaccination = vaccination;
            }
        }

        if (lastVaccination != null)
        {
            if (lastVaccination.DoseNumber < 3)
            {
                DateTime dueDate = lastVaccination.VaccinatedDate.AddDays(30);
                if (DateTime.Now <= dueDate)
                {
                    Console.WriteLine($"\nYour next due date is: {dueDate.ToString("dd/MM/yyyy")}");
                }
                else
                {
                    Console.WriteLine("\nYou can take vaccine now");
                }
            }
            else
            {
                Console.WriteLine("\nYou have completed the vaccination course. Thanks for your participation in the vaccination drive.");
            }
        }
        else
        {
            Console.WriteLine("\n  You don't have any vaccination history");
        }
    }

    public static void BeneficiaryRegistration()
    {
        Console.WriteLine("\nBeneficiary Registration\n------------------------");
        
        Console.Write("Enter Beneficiary Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Age: ");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Enter Gender: ");
        Gender gender = Enum.Parse<Gender>(Console.ReadLine(), true);
        
        Console.Write("Enter Mobile Number: ");
        long mobile = long.Parse(Console.ReadLine());

        Console.Write("Enter City: ");
        string city = Console.ReadLine();

        Beneficiary beneficiary = new Beneficiary(name, gender, mobile, city, age);

        beneficiaryList.Add(beneficiary);

        Console.WriteLine($"\nBeneficiary registered successfully! \n\nYour Register Number is: {beneficiary.RegisterNumber}");
    }

    public static void SetBeneficiarySampleData()
    {
        beneficiaryList.Add(new Beneficiary("Ravichandran", Gender.Male, 8484484, "Chennai", 21));
        beneficiaryList.Add(new Beneficiary("Baskaran", Gender.Male, 8484747, "Chennai", 22));
    }

    public static void SetVaccineSampleData()
    {
        vaccineList.Add(new Vaccine("Covishield", 48));
        vaccineList.Add(new Vaccine("Covaccine", 49));     
    }

    public static void SetVaccinationSampleData()
    {
        vaccinationList.Add(new Vaccination("BID1001", "CID101", 1, new DateTime(2021, 11, 11)));
        vaccinationList.Add(new Vaccination("BID1001", "CID101", 2, new DateTime(2022, 3, 11)));
        vaccinationList.Add(new Vaccination("BID1002", "CID102", 1, new DateTime(2022, 4, 4)));
    }
}
