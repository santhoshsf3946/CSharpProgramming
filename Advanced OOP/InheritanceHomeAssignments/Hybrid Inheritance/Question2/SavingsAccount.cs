using System;

namespace Question2
{
    public enum AccountType { Default, Savings, Balance }
    public class SavingsAccount : IDInfo, ICalculate, IBankInfo
    {
        public long AccountNumber { get; set; }
        
        public AccountType AccountType { get; set; }

        public double Balance { get; set; }

        public string BankName { get; set; }

        public string IFSC { get; set; }

        public string Branch { get; set; }

        public SavingsAccount(string name, Gender gender, DateTime dOB, long accountNumber, AccountType accountType, string bankName, string iFSC, string branch, long mobile, string mail, long voterID, long aadharID, string pANNumber) : base(name, gender, dOB, mobile, mail, voterID, aadharID, pANNumber)
        {
            AccountNumber = accountNumber;
            AccountType = accountType;
            BankName = bankName;
            IFSC = iFSC;
            Branch = branch;
        }

        public void CheckBalance()
        {
            Console.WriteLine("\tYour account balance is: " + Balance);
        }

        public void Deposit(int amount)
        {
            Balance += amount;
            Console.WriteLine("\tAmount deposited successfully !");
        }

        public void Withdraw(int amount)
        {
            Balance -= amount;
            Console.WriteLine("\tAmount withdrawed successfully !");
        }
    }
}
