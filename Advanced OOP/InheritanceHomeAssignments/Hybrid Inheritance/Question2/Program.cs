using System;
namespace Question2;

public class Program
{
    public static void Main(string[] args)
    {
        SavingsAccount savings = new SavingsAccount("Santhosh", Gender.Male, new DateTime(2000, 8, 21), 47293847983, AccountType.Savings, "HDFC", "HDFC7788", "Chetpet", 874298473, "santhosh@mail.com", 874247832987, 449234723982, "PAN782346784");

        savings.CheckBalance();
        savings.Deposit(21500);
        savings.CheckBalance();
        savings.Withdraw(5000);
        savings.CheckBalance();
    }
}
