using System;

namespace Question3
{
    public enum AccountType { Default, Savings, Balance }
    public class SavingsAccount : PersonalInfo, ICalculate
    {
        public long AccountNumber { get; set; }
        
        public AccountType AccountType { get; set; }

        public double Balance { get; set; }
        
        public SavingsAccount(long accountNumber, AccountType accountType, int pANNumber, string name, Gender gender, DateTime dOB, long phone) : base(pANNumber, name, gender, dOB, phone)
        { 
            AccountNumber = accountNumber;
            AccountType = accountType;
            Balance = 0;
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
