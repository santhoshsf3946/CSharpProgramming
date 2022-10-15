using System;
namespace Question3;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("\nSavings Account\n");
        SavingsAccount savingsAccount = new SavingsAccount(9834723894729, AccountType.Savings, 84274343, "Santhosh", Gender.Male, new DateTime(2000, 8, 21), 823477439);
        savingsAccount.Deposit(10000);
        savingsAccount.Withdraw(2500);
        savingsAccount.CheckBalance();

        Console.WriteLine("\nRecurring Deposit\n");
        RecurringDeposit recurringDeposit = new RecurringDeposit(8428374674283, AccountType.Balance, 35645434, "Dinesh", Gender.Male, new DateTime(2000, 9, 27), 783463742);
        recurringDeposit.Deposit(17000);
        recurringDeposit.Withdraw(7800);
        recurringDeposit.CheckBalance();
    }
}
