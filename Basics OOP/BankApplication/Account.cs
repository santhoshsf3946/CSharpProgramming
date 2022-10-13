using System;

namespace BankApplication
{
    public enum Gender { Default, Male, Female, Transgender }
    public enum AccountType { Default, SD, FD, RD }
    public class Account
    {
        private static long s_accountNumber = 3946000000;
        
        public string AccountNumber { get; }
        
        
        public string Name { get; set; }
        public string FatherName { get; set; }
        public Gender Gender { get; set; }
        public DateTime DOB { get; set; }
        public AccountType AccountType { get; set; }
        public double Balance { get; set; }

        public Account(string name, string fatherName, Gender gender, DateTime dob, AccountType accountType)
        {
            s_accountNumber++;
            AccountNumber = s_accountNumber + "";
            Name = name;
            FatherName = fatherName;
            Gender = gender;
            DOB = dob;
            AccountType = accountType;
        }

        public void Deposit ()
        {
            Console.Write("\nEnter amount to deposit: ");
            double amount = double.Parse(Console.ReadLine());

            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine("Amount depositted successfully");
            }
            else
            {
                Console.WriteLine("Invalid Amount");
            }
        }

        public void Withdraw ()
        {
            Console.Write("\nEnter amount to withdraw: ");
            double amount = double.Parse(Console.ReadLine());

            if (amount <= Balance && amount > 0)
            {
                Balance -= amount;
                Console.WriteLine("Amount withdrawed successfully");
            }
            else
            {
                Console.WriteLine("Insufficient balance");
            }
        }

        public void ShowkBalance()
        {
            Console.WriteLine("\nAvailable balance is: " + Balance);
        }
    }
}
