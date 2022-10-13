using System;
using System.Collections.Generic;
namespace BloodBank;

public class Program
{
    public static List<Donar> donarList = new List<Donar>();
    public static List<Donation> donationList = new List<Donation>();

    static Donar currentDonar = null;

    public static void Main(string[] args)
    {
        Console.WriteLine("================ Blood Bank Management ================");

        ShowMainMenu();
    }

    public static void ShowMainMenu()
    {
        int choice;
        do
        {
            Console.WriteLine("\n\t1. User Registration \n\t2. User Login \n\t3. Fetch Donar Details \n\t4. Exit");
            Console.Write("Select an option form the above choice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                {
                    UserRegistration();
                    break;
                }
                case 2:
                {
                    Login();
                    break;
                }
                case 3:
                {
                    FetchDonarDetails();
                    break;
                }
                case 4:
                {
                    Console.WriteLine("\nExitting...\n");
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

    public static void UserRegistration()
    {
        Console.WriteLine("\nDonar regisration\n-----------------");

        Console.Write("  Enter Donar Name: ");
        string name = Console.ReadLine();

        Console.Write("  Enter Age: ");
        int age = int.Parse(Console.ReadLine());

        Console.Write("  Enter Mobile Number: ");
        long mobile = long.Parse(Console.ReadLine());

        Console.Write("  Enter Blood Group: ");
        BloodGroup bloodGroup = Enum.Parse<BloodGroup>(Console.ReadLine(), true);

        Console.Write("  Enter Last Donation date ( dd/MM/yyyy ): ");
        DateTime lastDonationDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

        Donar newDonar = new Donar(name, mobile, bloodGroup, age, lastDonationDate);

        donarList.Add(newDonar);

        Console.WriteLine($"\nDonar registered successfully and Donar ID is: {newDonar.DonarID}");
    }

    public static void Login()
    {
        Console.Write("\nEnter donar id: ");
        string donarID = Console.ReadLine().Trim().ToUpper();

        foreach (var donar in donarList)
        {
            if (donarID == donar.DonarID)
            {
                currentDonar = donar;
                Console.WriteLine($"\nLogin successfully\tWelcome {currentDonar.DonarName}");
                ShowSubMenu();
            }
        }

        if (currentDonar == null)
        {
            Console.WriteLine("Invalid User Input");
        }
    }

    public static void ShowSubMenu()
    {
        string choice;
        do
        {
            Console.WriteLine("\n\t  i. Donate Blood \n\t ii. Donation History \n\tiii. Next Eligible date \n\t iv. Logout");
            Console.Write("Select one of the above choices: ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "i":
                {
                    DonateBlood();
                    break;
                }
                case "ii":
                {
                    DonationHistory();
                    break;
                }
                case "iii":
                {
                    if (currentDonar.ShowEligiblityDate() > DateTime.Now)
                    {
                        Console.WriteLine($"\nYour next eligible date for donation is: {currentDonar.ShowEligiblityDate().ToString("dd/MM/yyyy")}");
                    }
                    else
                    {
                        Console.WriteLine("\nYou are eligible for next blood donation");
                    }
                    break;
                }
                case "iv":
                {
                    Console.WriteLine("\nLogged out successfully !");
                    break;
                }
                default:
                {
                    Console.WriteLine("\nInvalid Input");
                    break;
                }
            }
        } while (choice != "iv");
    }

    public static void DonateBlood()
    {
        Console.Write("\nEnter Weight: ");
        double weight = double.Parse(Console.ReadLine());

        Console.Write("Enter Blood Pressure: ");
        double bloodPressure = double.Parse(Console.ReadLine());

        Console.Write("Enter Hemoglobin Count: ");
        double hemoglobinCount = double.Parse(Console.ReadLine());

        if (weight > 50 && bloodPressure < 130 && hemoglobinCount > 13)
        {
            if (currentDonar.ShowEligiblityDate() < DateTime.Now)
            {
                Donation newDonation = new Donation(currentDonar.DonarID, DateTime.Now, weight, bloodPressure, hemoglobinCount);
                donationList.Add(newDonation);
                currentDonar.LastDonationDate = newDonation.DonationDate;
                Console.WriteLine($"\nBlood donated successfully !, Donation ID is: {newDonation.DonationID}");
            }
            else
            {
                Console.WriteLine("\nYou are not completed 56 days after the previous donation");
            }
        }
        else
        {
            Console.WriteLine("\nYou are not eligible for donating blood");
        }
    }

    public static void DonationHistory()
    {
        Console.WriteLine();
        bool found = false;
        foreach (var donation in currentDonar.GetDonationDetails(donationList))
        {
            donation.ShowDonationDetails();
            found = true;
        }

        if (!found)
        {
            Console.WriteLine("No history found");
        }
    }

    public static void FetchDonarDetails()
    {
        Console.Write("\nEnter blood group for searching donars: ");
        BloodGroup bloodGroup = Enum.Parse<BloodGroup>(Console.ReadLine(), true);

        Console.WriteLine("\nAvailable Donars\n----------------");
        bool found = false;
        foreach (var donar in donarList)
        {
            if (bloodGroup == donar.BloodGroup)
            {
                Console.WriteLine($"  Donar Name: {donar.DonarName}  Mobile Number: {donar.Mobile}");
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("\nNo Donars found");
        }
    }
}
