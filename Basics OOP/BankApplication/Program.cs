using System;
using System.Collections.Generic;
namespace BankApplication;

public class Program
{
   
    public static void Main(string[] args)
    {
        Console.WriteLine("================= Bank Application =================");
        Console.WriteLine("Bank Account Creation:");
        Console.WriteLine("----------------------");

        List<Account> accountList = new List<Account>();

        string choice = "yes";

        while (choice == "yes")
        {
            Console.Write("\nEnter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your father's name: ");
            string fatherName = Console.ReadLine();

            Console.Write("Enter Your gender: ");
            Gender gender;
            bool temp1 = Enum.TryParse<Gender>(Console.ReadLine(), true, out gender);

            Console.Write("Enter your date of birth (dd/MM/yyyy): ");
            DateTime dob = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

            Console.Write("Enter your account type: ");
            AccountType accountType;
            bool temp2 = Enum.TryParse<AccountType>(Console.ReadLine(), true, out accountType);

            Account account = new Account(name, fatherName, gender, dob, accountType);

            accountList.Add(account);

            Console.WriteLine("\nAccount registered successfully!");

            Console.WriteLine("\n====================================================");
            Console.Write("Do you want to create another account: ");
            choice = Console.ReadLine().ToLower();
            Console.WriteLine("====================================================");
        }

        Console.WriteLine("\nRegistered Accounts Details:");
        Console.WriteLine("----------------------------");

        int count = 1;

        foreach (Account account in accountList)
        {
            Console.WriteLine($"\n{count}) Account holder name: {account.Name}, Account number: {account.AccountNumber}");
            Console.WriteLine($"\tFather nather name: " + account.FatherName);
            Console.WriteLine($"\tGender: " + account.Gender);
            Console.WriteLine($"\tDate of birth: " + account.DOB.ToShortDateString());
            Console.WriteLine($"\tAccount type: " + account.AccountType);
            Console.WriteLine($"\tAccount balance: Rs. " + Math.Round(account.Balance, 2));
            account.Deposit();
            account.Withdraw();
            account.ShowkBalance();
            count++;
        }

        Console.WriteLine();
    }
}
